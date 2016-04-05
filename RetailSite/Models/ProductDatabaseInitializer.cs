using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RetailSite.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Stereos"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Speakers"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Subwoofers"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Amplifiers"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Accessories"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Dual XR4120",
                    Description = "If you're just not listening to CDs anymore, Dual's XR4120 digital media receiver gives you a wallet-friendly way to enjoy your music collection on the road. You can listen to your favorite AM/FM stations, plug a thumb drive full of music into the USB port, jack your music player into the front minijack aux input, or fold down the faceplate to insert an SD card. It all sounds great on this Dual receiver, thanks to the healthy output of the built-in MOSFET amplifier. The detachable faceplate features a 10-character black-on-white display that's easy to read day or night. The included wireless remote adds convenience and control, while a set of rear preamp outputs will come in handy when you decide to expand your system.", 
                    ImagePath="DualXR4120.jpg",
                    UnitPrice = 54.99,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "JVC KD-R370",
                    Description = "Got an old work truck or a teen's first car that needs some tunes? Or do you simply need to replace a burned-out factory radio? JVC's KD-R370 CD receiver delivers strong sound without costing a ton of money. It includes a sensitive AM/FM radio tuner, CD playback with MP3 and WMA compatibility, and a front auxiliary input, so you can hook up your smartphone or portable music player to expand your music options.",
                    ImagePath="h105KDR370-F.jpg",
                    UnitPrice = 64.99,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Sony DSX-A40UI",
                    Description = "Bells and whistles are nice, but you don't necessarily need them to go all-digital in your car. The DSX-A40UI has all the basics covered, starting with a sleek-looking removable faceplate that also offers the functionality you need to enjoy your digital music library. A handy USB port gives you lots of options for enjoying your digital music.Plug in a flash drive that you've loaded up with music, or connect your iPod®, iPhone®, or Android™ to listen to music and charge the device. You'll be able to use the receiver's controls to search through your music, and Sonys Quick - BrowZer feature makes it easy to find music by artist, album, genre, song or playlist.You can also connect a satellite radio tuner or a portable music player to the front auxiliary input.",
                    ImagePath="h158DSXA40U-F.jpg",
                    UnitPrice = 64.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Soundstream VR-651B",
                    Description = "While you can use Soundstream's 6.5in LCD screen to view movies and video when your car is parked, it works as a great display for system and song info. If you want to take your show on the road, connect video screens to the receiver's video output and keep your passengers entertained. The receiver will play any MP4, XVID, and DivX video that you've loaded onto a USB device or DVD. For your music fix, you can slide in just about any disc, even a recordable DVD loaded with MP3 or WMA files. The USB port and auxiliary input offer plenty of other ways to check out all your media. This Soundstream includes five EQ presets for quick tone changes.For some more impact out of your system, the VR - 651B's six preamp outputs let you connect amplifiers to power your speakers and a subwoofer.Use this super fast car to entertain guests. Lights and doors work!",
                    ImagePath ="h530VR651B-F.jpg",
                    UnitPrice = 154.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Pioneer AVH-4100NEX",
                    Description = "If you crave the best sound quality, you'll be stoked that the AVH-4100NEX supports FLAC file playback, for compression-free CD-quality sound when you're cruising down the highway. And don't forget, you can also enjoy all your CDs, DVDs, discs full of MP3 or WMA music, SD cards, or USB storage devices loaded with files. You can connect your iPod® or iPhone to one the receiver's two rear USB inputs and use the receiver's controls to access your playlists, with tools like Alphabet Search and Link Search to help you zero in on the song you want. Android users — you'll be able to browse and play back the music that's stored on many Android phones.",
                    ImagePath="h1304100NEX-F.jpg",
                    UnitPrice = 599.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Infinity Reference X REF-8602cfx",
                    Description = "Do you want to hear the details you've been missing in your car's sound system? You'll enjoy exceptional clarity from Infinity's Reference X Series REF-8602cfx 5x7/6x8 speakers. Infinity's UniPivot design allows you to aim each textile, edge-driven tweeter toward your ears, so you enjoy excellent stereo imaging even if the speakers are mounted way down low in your doors. Each tweeter features a level control switch so you can boost the brightness to your taste.",
                    ImagePath="h108R8602CX-f.jpg",
                    UnitPrice = 34.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Kenwood KFC-1665S",
                    Description = "The KFC-1665S 6-1/2in 2-way speakers feature polypropylene cones that will enrich your music with all the midbass and midrange details while the 1in balanced-dome tweeters will make high notes soar. Kenwood also includes sharp-looking grilles in case you're doing a custom installation in your vehicle. Finally, you can enjoy your music the way it was meant to be heard, with clarity and emotion.",
                    ImagePath ="h1131665S-F.jpg",
                    UnitPrice = 19.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Polk Audio db651s",
                    Description = "Polk's db651s shallow-mount speakers feature 6-1/2in woofers made from a polymer/mica composite and durable rubber surrounds that stand up to heat and moisture. Liquid-cooled 3/4 silk/polymer dome tweeters use powerful Neodymium magnets to deliver precise high-frequency reproduction. With a 2 mounting depth, these speakers can fit into some tight places. The built-in two-way crossovers keep the high and low frequencies flowing to the proper drivers for seamless, efficient audio.",
                    ImagePath="h107DB651S-o_dg2.jpeg",
                    UnitPrice = 35.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Infinity Reference X REF-6502ix",
                    Description = "Do you want to hear the details you've been missing in your car's sound system? You'll enjoy exceptional clarity from Infinity's Reference X Series REF-6502ix 6-3/4 speakers. Infinity's UniPivot design allows you to aim each textile dome tweeter toward your ears, so you enjoy excellent stereo imaging even if the speakers are mounted way down low in your doors. Each tweeter features a level control switch so you can boost the brightness to your taste.",
                    ImagePath="h108R6502iX-o_front.jpeg",
                    UnitPrice = 29.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "JL Audio 10W0v3-4",
                    Description = "The JL Audio name means high-quality sound, and the 10W0v3-4 10 subwoofer doesn't come up short when delivering trademark JL performance. You'll find patented technologies like an optimized motor system that promotes precise, linear cone movement, plus advanced cooling systems throughout the frame for rapid heat dissipation.",
                    ImagePath="h13610W0V34-F.jpeg",
                    UnitPrice = 109.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "JL Audio 10TW3-D4",
                    Description = "If you've got a pickup truck, sports car, or you just need to haul a lot of stuff, then you know that adding some bass can be a challenge. That's why JL Audio built the TW3 Series 10TW3-D4 shallow-mount subwoofer. This super-thin 10 sub puts out big bass, yet only requires minimum air space, so you can use a much smaller enclosure. Now, you can have your bass and your space too.",
                    ImagePath="h13610TW3-F.jpg",
                    UnitPrice = 254.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Rockford Fosgate Punch P1S2-10",
                    Description = "Rockford Fosgate showcases their fanatical commitment to sonic excellence in the Punch Series of speakers, amps, and subs. If you like to listen to potent, powerful music — and feel it too — Punch components will give you impressive sound that'll stand out in a crowd.Engineers at Rockford Fosgate designed the P1S2-10 10 subwoofer to dish out the kind of powerful low end you crave in your ride. Its responsive paper cone is reinforced with the same Kevlar® fibers used in bulletproof vests so you get the best of both worlds — warm bass that's exceptionally hard-hitting. Rockford Fosgate uses a new technique to attach the oversized rubber surround to the cone that increases available cone area up to 25%, so this sub can push more air for even bigger bass.The P1S2-10 sub features an extended pole piece and bumped backplate that leaves more room for heavy excursion, so it'll hit deeper lows without bottoming out.This sub works equally well in a sealed or ported enclosure, so you can choose the kind of bass you want for your system. The sub's 2 - ohm impedance will draw maximum wattage from your mono sub amp.",
                    ImagePath="h575P1S210-o_trim.jpg",
                    UnitPrice = 69.99,
                    CategoryID = 3
                },
                //new Product
                //{
                //    ProductID = 13,
                //    ProductName = "Big Ship",
                //    Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " + 
                //                  "artifically intelligent computer brain!",
                //    ImagePath="boatbig.png",
                //    UnitPrice = 95.00,
                //    CategoryID = 4
                //},
                new Product
                {
                    ProductID = 14,
                    ProductName = "Wet Sounds HT-4",
                    Description = "The Wet Sounds HT-4 amp packs a phenomenal amount of punch into a compact package that's ideal for your boat or car stereo system. This Class D full-range amplifier can be configured to run almost any speaker combination — from multiple speakers and tower set-ups to high-powered subwoofers. With high-pass and low-pass filters plus bass boost on all channels, you'll be able to fine-tune your system to get the sound you want. The HT-4 also lets you enjoy the convenience of RCA input summing. With this feature, you can drive all channels with one set of RCA cables without the need for RCA Y-adapters.",
                    ImagePath="h867HT4-F.jpg",
                    UnitPrice = 219.99,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Kicker 40KX2400.1",
                    Description = "Kicker's KX2400.1 mono subwoofer amplifier will power your bass system with up to 2,400 watts RMS. This reliable and compact KX Series rocker remains cool even when pushed hard, thanks to its high-mass heatsink, high-tech internal components, and efficient Class-D amp technology. And Kicker managed to pack more watts per square inch inside the KX2400.1 amplifier than almost any other mono subwoofer amp made.",
                    ImagePath="h2064KX24K1-o_front.jpg",
                    UnitPrice = 1099.99,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "EFX 9-Wire Ultra Flex Speaker Wire",
                    Description = "If you're keeping your factory receiver and installing an aftermarket amp and four speakers, Scosche's EFX 9-Wire Ultra Flex speaker wire makes running wire as easy as it gets. They bundle nine individually-jacketed, extra-strong wires into one handy cable with a rugged PVC outer jacket. That's enough to wire four speakers, with one wire reserved for your amplifier's turn-on function.",
                    ImagePath="h1429WC1820-F.jpg",
                    UnitPrice = 29.99,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}
