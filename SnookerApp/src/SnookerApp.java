import javax.swing.*;
import java.io.*;
import javax.swing.filechooser.FileNameExtensionFilter;
import javax.swing.text.JTextComponent;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ComponentAdapter;
import java.awt.event.ContainerAdapter;
import java.nio.file.Files;
import java.nio.file.Paths;

public class Main
{
   public static void listFilesForFolder(final File folder)
    {
        //here I just look at which files are in my folder, so I just create a List with all the names/files of my directionary.
        //and then I let it print out the names, just for the programmer as a kind of check.
        for (final File fileEntry : folder.listFiles())
        {
            if (fileEntry.isDirectory())
            {
                listFilesForFolder(fileEntry);
            }
            else
            {
                System.out.println(fileEntry.getName());
            }
        }
    }

    public static void main(String[] args) throws IOException
    {
        //so here I'll look if the directionary "Snookerplayers" does exist, if it does not, then I create a new one with the same name.
        File Directionary = new File("C:\\Documents\\Snookerplayers");
        if (!Directionary.exists())
        {
            Directionary.mkdirs();
        }

        //#region Creating Files
        
        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFiles = new File("C:\\Documents\\Snookerplayers\\Ronnie");
            if (myFiles.createNewFile())
            {
                System.out.println("File created: " + myFiles.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Ronnie - The Rocket - O'Sulivan ist der Rekordhalter der meisten Maximum-Breaks (147 Punkte müssen hier erreicht werden, also eine Total Clearence), meisten Ranglisten-Siege (39 Stück Ranglistensiege) und gemeinsam mit Stephen Hendry der, der am meisten Weltmeisterschaften, der modernen Crucible Era (sprich seit 1977, da man im Crucible Theatre, Sheffield, seit dieser Zeit die WMs ausfechtet).   ";
            String path = "C:\\Documents\\Snookerplayers\\Ronnie";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Higgins");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "John Higgins- The Wizard of Wishaw - ist einer der erfolgreichsten Spieler der Geschichte. Vier Mal hat der Sir aus Schottland die Weltmeisterschaft gewinnen können (1998, 2007, 2009 & 2011). Zudem hat er 31 Ranglisten-Turniere gewonnen und liegt somit hinter The Rocket und The Nugget, die mehr Turniere als er gewinnen konnten. Er teilt sich den 4 Platz, derjenigen die am meisten Triple Crown Titel gewinnen konnten mit dem Jester von Leceister, Mark Selby. Nur O'Sullivan, Hendry und Steve Davis konnten mehr als die beiden gewinnen. Auch besitzt er den 2. Platz auf der Rangliste mit den meinsten Maximums, nämlich liegt er dort mit 12 Maximums hinter Ronnie O'Sullivan.";
            String path = "C:\\Documents\\Snookerplayers\\Higgins";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Reardon");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                //here is just a normal text, which helps me finding out problems of this program
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Ray Reardon ist ein ehemaliger walisischer Snookerspieler, der Dracula genannt wurde. Insgesamt gewann er die WM 6 Mal (1970, 1973, 1974, 1975, 1976 & 1978). Er besitzt zudem den MBE (Member of the Most Excellent Order of the British Empire). Sogar Ronnie wurde von Reardion eine zeitlang trainiert.";
            String path = "C:\\Documents\\Snookerplayers\\Reardon";
            Files.write(Paths.get(path), content.getBytes());
        } catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Milkins");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Robert 'The Milkman' Milkins hat schon 2 Ranglistentitel geholt. Gerade erst hat er die Welsh Open gegen Shaun Murphy im Finale gewonnen.";
            String path = "C:\\Documents\\Snookerplayers\\Milkins";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Doherty");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Ken - The Darling of Dublin - Doherty ist einer der erfolgreichsten Snookerspieler Irlands, gehörte jahrelang zur Weltspitze und gewann zahlreiche Turniere wie die Snookerweltmeisterschaft 1997. Auf der Snookerweltrangliste erreichte er zeitweise Platz 2.";
            String path = "C:\\Documents\\Snookerplayers\\Doherty";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\SDavis");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Steve - The Nugget - Davis ist ein OBE (Officer of the Most Excellent Order of the British Empire) ist ein ehemaliger englischer Snookerspieler. Er war von 1978 bis 2016 durchgängig Profispieler auf der Snooker Main Tour und galt in den 1980er-Jahren als dominierender Spieler. Davis gewann jeweils sechsmal die Snookerweltmeisterschaft und die UK Championship sowie drei Mal das Masters und ist somit Mitglied der Triple Crown.";
            String path = "C:\\Documents\\Snookerplayers\\SDavis";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Trump");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Judd - The Ace in the Pack - Trump ist ein englischer Snookerspieler und ehemaliger Erster der Weltrangliste. Trump hat in seiner seit 2005 andauernden Profizeit bisher 27 Ranglisten- und Einladungsturniere gewonnen (Stand 10. Februar 2021), darunter die UK Championship, das Masters und die Weltmeisterschaft. Durch den Gewinn dieser drei Titel wurde er der elfte Träger der Triple Crown.";
            String path = "C:\\Documents\\Snookerplayers\\Trump";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Bingham");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Stuart - ball-run - Bingham ist ein englischer Profi-Snooker-Spieler, ehemaliger Weltmeister und Masters-Sieger. Bingham gewann 1996 die Amateur-Weltmeisterschaft, hatte aber zu Beginn seiner Profikarriere wenig nachhaltigen Erfolg. Mit Mitte dreißig verbesserte sich seine Form: Im Alter von 35 Jahren gewann er bei den Australian Goldfields Open 2011 seinen ersten Ranglistentitel, wodurch er zum ersten Mal in die Top 16 der Rangliste aufstieg.\n" +
                    "Mit 38 Jahren gewann Bingham die Weltmeisterschaft 2015, als er Shaun Murphy im Finale mit 18:15 besiegte. Er war der älteste erstmalige Weltmeister in der Geschichte des Snooker und nach Ken Doherty der zweite Spieler, der sowohl als Amateur als auch als Profi Weltmeister wurde. Sein Weltmeistertitel brachte ihn auf Platz zwei der Weltrangliste, den er bis März 2017 innehatte. Bei den Masters 2020 gewann er seinen zweiten Triple Crown-Titel, indem er Ali Carter im Finale mit 10:8 besiegte. Mit 43 Jahren und 243 Tagen löste er Ray Reardon als ältesten Masters-Champion ab. 2017 erhielt Bingham eine sechsmonatige Wettkampfsperre, weil er gegen die Regeln für Wetten auf Spiele verstoßen hatte, an denen er und andere Spieler beteiligt waren.\n" +
                    "Bingham ist ein produktiver Breaker und hat in seiner Karriere über 550 Century Breaks erzielt. Er hat neun Maximalbreaks in seiner Karriere erzielt, die viertmeisten aller Spieler, hinter Ronnie O'Sullivan (15), John Higgins (12) und Stephen Hendry (11).";
            String path = "C:\\Documents\\Snookerplayers\\Bingham";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Selby");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Mark \"The Shark\" Selby ist ein viermaliger Weltmeister und der einzige der in allen Triple-Crown Titel" +
                    " (sprich UK-Championship, Masters und Weltmeisterschaft) gegen Ronnie gewonnen hat. " +
                    "Er ist auch Rekord Halter bei den meisten Minor Titel Siegen, mit 7 Stück an der Zahl. ";
            String path = "C:\\Documents\\Snookerplayers\\Selby";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Allen");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Mark - The Pistol - Allen ist ein nordirischer Profi-Snookerspieler aus Antrim. Er gewann 2004 die Amateur-Weltmeisterschaft, wurde im darauffolgenden Jahr Profi und brauchte nur drei Spielzeiten, um die Top 16 zu erreichen. In seiner vierten Profisaison schlug er den Titelverteidiger Ronnie O'Sullivan auf dem Weg ins Halbfinale der Weltmeisterschaft 2009, wo er gegen den späteren Sieger John Higgins verlor. Allen erreichte sein erstes Ranking-Finale bei der UK Championship 2011, wo er gegen Judd Trump verlor. Im folgenden Jahr gewann er bei den World Open 2012 seinen ersten Ranglisten-Titel. Seinen ersten Triple-Crown-Titel holte er, als er Kyren Wilson beim Masters 2018 besiegte, und seinen zweiten, als er Ding Junhui bei der UK Championship 2022 besiegte. Insgesamt hat er in seiner Karriere neun Ranglistentitel gewonnen. Die Saison 2022-23 war die bisher beste in Allens Karriere, da er vier Ranglistenfinale erreichte, drei Ranglistentitel gewann - bei den Northern Ireland Open 2022, der UK Championship 2022 und dem World Grand Prix 2023 - und ein Karrierehoch von Platz drei in der Weltrangliste erreichte. Bei der World Snooker Championship 2023 erreichte er das zweite Halbfinale seiner Karriere, verlor aber mit 15:17 gegen Mark Selby. Allen ist ein produktiver Break-Bauer und hat im Profi-Wettbewerb mehr als 550 Century Breaks erzielt. Er hat zwei Maximum-Breaks geschafft, sein erstes bei der UK Championship 2016 und sein zweites in der Qualifikationsrunde der Northern Ireland Open 2021.";
            String path = "C:\\Documents\\Snookerplayers\\Allen";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Carter");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Ali Carter ist ein englischer Snookerspieler, der seit den 1990ern Profispieler ist. In dieser Zeit wurde er zwei Mal Vize-Weltmeister, erreichte Platz 2 der Snookerweltrangliste und spielte drei Maximum Breaks. Auch hat er 5 Ranglisten Titel geholt und einen Minor Titel. ";
            String path = "C:\\Documents\\Snookerplayers\\Carter";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Murphy");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Shaun Murphy ist ein englischer Profi-Snookerspieler, der 2005 die Weltmeisterschaft gewann. Murphy, der den Spitznamen \"The Magician\" trägt, ist bekannt für seinen geraden Queue-Einsatz und seine Long Pots.\n" +
                    "\n" +
                    "Geboren in Harlow, Essex, und aufgewachsen in Irthlingborough, North Northamptonshire, wurde Murphy 1998 Profi. Sein Sieg bei der Weltmeisterschaft 2005 galt als große Überraschung, da er nach Alex Higgins und Terry Griffiths erst der dritte Qualifikant war, der den Titel gewann. Er hat elf Ranglistentitel gewonnen und steht damit auf Platz zehn der Ranglistenturniersiege aller Zeiten. Außerdem erreichte er 2009 ein zweites, 2015 ein drittes und 2021 ein viertes Weltmeisterschaftsfinale. Murphy hat auch elf Turniere außerhalb der Rangliste gewonnen, darunter das Masters 2015, mit dem er die Triple Crown seiner Karriere komplettierte.\n" +
                    "\n" +
                    "Murphy hat über 4 Millionen Pfund an Preisgeldern gewonnen und in seiner Profikarriere mehr als 600 Century Breaks erzielt. Seine höchste Weltranglistenposition war die Nummer drei, die er nach 2007/08 drei Saisons lang hielt.\n" +
                    "\n" +
                    "Am 12. November 2017 gewann Murphy den Titel des Champion of Champions, indem er Ronnie O'Sullivan im Finale besiegte. Bei der Snooker-Weltmeisterschaft 2019 wurde Murphy erst der zweite Mensch, der bei den Weltmeisterschaften einen Whitewash schaffte, indem er Luo Honghao in der ersten Runde mit 10:0 besiegte.";
            String path = "C:\\Documents\\Snookerplayers\\Murphy";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Junhui");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Ding Junhui - The Dragon from the East - ist ein chinesischer Profi-Snookerspieler. Er ist der erfolgreichste asiatische Spieler in der Geschichte des Sports. Im Laufe seiner Karriere hat er 14 wichtige Ranglistentitel gewonnen, darunter drei UK-Championship-Titel(2005, 2009, 2019). Zweimal erreichte er das Finale des Masters, einmal gewann er 2011. Im Jahr 2016 erreichte er als erster asiatischer Spieler das Finale der Weltmeisterschaft. Ding begann im Alter von neun Jahren mit dem Snookerspiel und erlangte 2002 internationale Bekanntheit, nachdem er die U21-Asienmeisterschaft und die Asienmeisterschaft gewonnen hatte. Im Alter von 15 Jahren wurde er der jüngste Gewinner der IBSF-Weltmeisterschaft der unter 21-Jährigen. Im Jahr 2003 wurde Ding im Alter von 16 Jahren Profi. Seine ersten großen Erfolge als Profi feierte er 2005, als er die China Open und die UK-Meisterschaft gewann und damit der erste Spieler außerhalb Großbritanniens und Irlands war, der diese Titel erringen konnte. Im Laufe seiner Karriere hat er mehr als 600 Century Breaks, darunter sechs Maximum Breaks, im professionellen Spiel erzielt. Er ist der einzige asiatische Spieler, der die Nummer eins der Weltrangliste ist. 2014 wurde er der elfte Spieler, der diese Position erreichte. Er lebt seit langem in Sheffield, England, und besitzt in derselben Stadt die Ding Junhui Snooker Academy.";
            String path = "C:\\Documents\\Snookerplayers\\Junhui";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Williams");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Mark James Williams MBE (geboren am 21. März 1975) ist ein walisischer Snooker-Profi, der in den Jahren 2000, 2003 und 2018 dreimal Weltmeister wurde. Williams ist oft für seine Fähigkeit, lange Pötte zu werfen, bekannt und hat sich den Spitznamen \"The Welsh Potting Machine\" (die walisische Pottmaschine) verdient. 1992 wurde Williams Profi und war dreimal die Nummer eins der Welt (1999-00, 2000-01 und 2002-03). Seine bisher erfolgreichste Saison war 2002-03, als er die Triple Crown gewann: die UK Championship, das Masters und die Weltmeisterschaft. Damit war er nach Steve Davis und Stephen Hendry erst der dritte Spieler, der alle drei Triple Crown Events in einer Saison gewinnen konnte. Er ist der erste (und bis heute einzige) Spieler, der alle drei Versionen der professionellen Weltmeisterschaft gewonnen hat: die World Snooker Championship, die Six-red World Championship und die World Seniors Championship. Williams ist der erste Linkshänder, der die Weltmeisterschaft gewonnen hat. Er hat 24 Ranglistenturniere gewonnen, darunter zwei UK-Championship-Titel(1999 und 2002), womit er den fünften Platz in der ewigen Bestenliste belegt. Außerdem hat er zwei Mal das Masters gewonnen (1998 und 2003). Nach seinem zweiten Weltmeistertitel im Jahr 2003 begann seine Form zu sinken; nach der Saison 2007/08 fiel er aus den Top 16 heraus, konnte aber 2009/10 seinen Platz wieder einnehmen. Williams hat mehr als 580 Century Breaks in professionellen Wettbewerben erzielt, darunter drei Maximum Breaks. Er wurde der älteste Spieler, der ein Maximum-Break in einem professionellen Wettbewerb schaffte, als er bei den English Open 2022 im Alter von 47 Jahren und 270 Tagen ein 147er schaffte.";
            String path = "C:\\Documents\\Snookerplayers\\Williams";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\JDavis");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Joe Davis war ein legendärer Snooker Spieler, er war der erste der eine Snookerweltmeisterschaft gewonnen hat und dann jedes Mal, wenn er teilgenommen hat,\n" +
                    "auch gewonnen hat. Er hat 15 Weltmeistertitel im Snooker, dazu kommen natürlich auch einige im English Billards. ";
            String path = "C:\\Documents\\Snookerplayers\\JDavis";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }

        try
        {
            //here I'll create a new File if it doesn't already exist. And also here just for me as a programmer, I'll just print it out
            File myFile = new File("C:\\Documents\\Snookerplayers\\Hendry");
            if (myFile.createNewFile())
            {
                System.out.println("File created: " + myFile.getName());
            }
            else
            {
                System.out.println("File already exists.");
            }

            //so here is the Text I just type into the file. And then with Files.write I just write every letter into the textfile
            String content = "Stephen 'Golden Boy' Hendry hat 7 Weltmeisterschaften gewonnen und ist damit mit Ronnie O'Sullivan Rekordhalter in der Kategorie 'Meiste WM-Titel seit der Crucible Ara' ";
            String path = "C:\\Documents\\Snookerplayers\\Hendry";
            Files.write(Paths.get(path), content.getBytes());
        }
        catch (IOException e)
        {
            //here is just a normal Exception
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
        //#endregion

        //#region Setting Properties of the JFrame
        //here I create my frame and then aswell a ComboBox with the Snookerplayers
        //with SetBound I can just write where I want to have that speciic Combobox. Then I just add it to my Snooker Frame
        //and I dont have a specific layout, that is why it is null
        //then with SetSize I can just set the size property of my JFrame and visible = true means that you can see the frame
        JFrame Snooker = new JFrame("Snooker");
        JComboBox cbShowSnookerPlayers = new JComboBox();
        cbShowSnookerPlayers.removeAllItems();
        cbShowSnookerPlayers.setBounds(100, 200, 323, 30);
        Snooker.add(cbShowSnookerPlayers);
        Snooker.setLayout(null);
        Snooker.setSize(2000, 1700);
        Snooker.setVisible(true);

        //here I have created a new Button called "Load Player" and I just setted the properties of it, like lenght width and so on and so forth
        //and then finally I'll just add it to the frame
        JButton loadplayer = new JButton("Load Player");
        loadplayer.setBounds(200, 100, 120, 20);
        Snooker.add(loadplayer);

        //here I created another button, so that I can delete players
        JButton deleteplayer= new JButton("Delete Player");
        deleteplayer.setBounds(200, 160, 120, 20);
        Snooker.add(deleteplayer);

        //so showtext is a TextArea and the bounds are setted too and then it got added to the Snooker Frame
        JTextArea showtext = new JTextArea();
        showtext.setEditable(true);
        showtext.setBounds(10, 260, 1900, 150);
        Snooker.add(showtext);

        //this is another Textarea where I just can write some stuff into and then I bounded it and added it to my Frame
        JTextArea writestuffinfile = new JTextArea();
        writestuffinfile.setBounds(10, 600, 1900, 150);
        Snooker.add(writestuffinfile);

        //Here is a new Button which can later on save players, I did made the boundaries here too and then added it too the Snooker Frame
        JButton saveplayer = new JButton("Save Player");
        saveplayer.setBounds(200, 500, 120, 20);
        Snooker.add(saveplayer);

        //So here is a new Textfield, where you can type in the name of you player
        JTextField Name = new JTextField();
        Name.setBounds(200, 550, 200, 20);
        Snooker.add(Name);

        //Here is just a label with a text, that the user does know more, and that he knows what he does have to do
        JLabel nameassistance = new JLabel();
        nameassistance.setText("Type in the Snookerplayers Name");
        nameassistance.setBounds(5, 550, 200, 20);
        Snooker.add(nameassistance);
        //#endregion

        //here I also look which Files are in the Directionary and then I just give them to list and if not I just add the files name again to the combobox
        final File folder = new File("C:\\Documents\\Snookerplayers\\");
        for (final File fileEntry : folder.listFiles())
        {
            if (fileEntry.isDirectory())
            {
                listFilesForFolder(fileEntry);
            }
            else
            {
                System.out.println(fileEntry.getName());
                cbShowSnookerPlayers.addItem(fileEntry.getName());
            }
        }

        //so here I just created a new Listener, so that the button does work when you clikc on it.
        saveplayer.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                FileWriter fwWriter = null; //so here I just created a new FileWriter, so I can write some stuff into a file
                try
                {
                    //here I just create a new file with the name of a textbox, in which a user can type in his wished File-Name
                    //and then I add the name to a combobox aswell
                    File myFile = new File("C:\\Documents\\Snookerplayers\\" + Name.getText() + "");
                    cbShowSnookerPlayers.addItem(Name.getText() + "");
                    if (myFile.createNewFile())
                    {
                        System.out.println("File created: " + myFile.getName()); //just for me as safety
                    }
                    else
                    {
                        System.out.println("File already exists."); //just fo me as a safety variant
                    }
                    fwWriter = new FileWriter(" " + Name.getText() + ""); //here I just write my new file and call it as the user wanted it to be
                }
                catch (IOException ex)
                {
                    System.out.println(ex); //just for me as a safety
                }
                try
                {
                    String content = writestuffinfile.getText(); //here I just write the typed text of my writestuff ... textbox into my string
                    String path = "C:\\Documents\\Snookerplayers\\" + Name.getText() + ""; //getting the right path
                    Files.write(Paths.get(path), content.getBytes()); //here I write the things into the file
                    writestuffinfile.write(fwWriter); //Object of JTextArea
                    writestuffinfile.setText("");
                    Name.setText("");
                }
                catch (IOException ex)
                {
                    System.out.println(ex); //just for me as a safety
                }
            }
        });

        //here I just created another Listener, so that I can click on the button and theres an clickevent
        loadplayer.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                String myName = (String) cbShowSnookerPlayers.getSelectedItem(); //getting my combobox item, which the user selected
                //then I just type in the text into the TextField, I just look at which item is selected
                //and then create a new file and read it with the bufferedreader method
                //and if there isn't a file there it just prints that out (obv. for me).
                //then I just append the line to the textfield.
                String typedText = ((JTextField) cbShowSnookerPlayers.getEditor().getEditorComponent()).getText();
                if (myName.equals("" + typedText + ""))
                {
                    showtext.setText("");
                    File file = new File("C:\\Documents\\Snookerplayers\\" + typedText + "");
                    BufferedReader readline = null;
                    try
                    {
                        readline = new BufferedReader(new FileReader(file));
                    }
                    catch (FileNotFoundException ex)
                    {
                        System.out.println("The file wasn't found");
                    }
                    String line = null;
                    try
                    {
                        line = readline.readLine();
                    }
                    catch (IOException ex)
                    {
                        System.out.println(ex);
                    }
                    while (line != null)
                    {
                        showtext.append(line + "\n");
                        try
                        {
                            line = readline.readLine();
                        }
                        catch (IOException ex)
                        {
                            System.out.println(ex.toString());;
                            System.out.println("File is used by another process"); //just for me
                        }

                        showtext.setFont(new Font("Serif", Font.ITALIC, 16)); //here I just set an other font, just that its not standard
                        showtext.setLineWrap(true);
                        showtext.setWrapStyleWord(true);
                        showtext.setEditable(false); //here I can add my text
                    }
                }
            }
        });

        //here I just created another Listener, so that I can click on the button and it deletes my selected item
        deleteplayer.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                //so firstly I am just getting the selected item of the combobox, and then  I just delete the file, with the
                //delete method, and also removing it from the combobox as well. 
                //This is kind of buggy, because it seems that it sometimes don't work and the other time it works again
                //because I tried it sometimes, and it worked and again it didnt 
                String selectedItem = (String) cbShowSnookerPlayers.getSelectedItem();
                File myFile = new File("C:\\Documents\\Snookerplayers\\" + selectedItem);
                if (myFile.delete())
                {
                    System.out.println("Deleted the file: " + myFile.getName());
                }
                else
                {
                    System.out.println("Failed to delete the file.");
                }
                cbShowSnookerPlayers.removeItem(selectedItem);
            }
        });      
    }

        /**
     * Method generated by IntelliJ IDEA GUI Designer
     * >>> IMPORTANT!! <<<
     * DO NOT edit this method OR call it in your code!
     *
     * @noinspection ALL
     */
}