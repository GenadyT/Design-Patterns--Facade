using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade;
using Facade.TheaterEquip;
using Logger = FormLogger.Logger;
using CMI = ClassMethLogger.ClassMethInfo;

namespace Facade
{
    public delegate void TheaterPrint(string equipNameChunk, string equipStatus);

    // -- Facade Class ---
    internal class HomeTheaterFacade
    {
        private const string ClassName = "HomeTheaterFacade";

        Amplifier amp;
        Tuner tuner;
        DVDPlayer dvd;
        CDPLayer cd;
        Projector projector;
        TheaterLigths ligths;
        TheaterEquip.Screen screen;
        PopcornPopper popper;

        public HomeTheaterFacade(TheaterPrint thPrint) : this(
            new Amplifier(thPrint),
            new Tuner(thPrint),
            new DVDPlayer(thPrint),
            new CDPLayer(thPrint),
            new Projector(thPrint),
            new TheaterLigths(thPrint),
            new TheaterEquip.Screen(thPrint),
            new PopcornPopper(thPrint)
        ) { }

        public HomeTheaterFacade(
            Amplifier amp,
            Tuner tuner,
            DVDPlayer dvd,
            CDPLayer cd,
            Projector projector,
            TheaterLigths ligths,
            TheaterEquip.Screen screen,
            PopcornPopper popper
            )
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.ligths = ligths;
            this.screen = screen;
            this.popper = popper;
        }

        public void TheaterOn(string movie)
        {
            const string MethodName = "watchMovie";
            Logger.WriteLine(CMI.MethInfo(ClassName, MethodName));
            Logger.WriteLine("Get ready to watch a movie...");

            popper.on();
            popper.pop();
            ligths.dim(10);
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.setDvd(this.dvd);
            amp.setSurroundSound();
            amp.setVolume(5);
            dvd.on();
            dvd.play(movie);
        }

        public void TheaterOff(string movie)
        {
            const string MethodName = "endMovie";
            Logger.WriteLine(CMI.MethInfo(ClassName, MethodName));
            Logger.WriteLine("Shutting movie theater down...");

            popper.off();
            ligths.on();
            screen.up();
            projector.off();
            amp.off();            
            dvd.stop();
            dvd.eject();
            dvd.off();
        }
    }
}
