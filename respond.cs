using System.Collections;

namespace Whitney
{//start of namespace
    public class respond
    {//start of public class respond
        public respond(ArrayList reply, ArrayList ignore)
        {//start of construct respond

            answers(reply);
            words(ignore);

        }//end of constructor respond

        //method to store the list of words
        private void words(ArrayList ignoring)
        {//start of method words

            //ignoring questions
            ignoring.Add("a");
            ignoring.Add("about");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyhow");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("anyway");
            ignoring.Add("anywhere");
            ignoring.Add("are");
            ignoring.Add("around");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("back");
            ignoring.Add("be");
            ignoring.Add("became");
            ignoring.Add("because");
            ignoring.Add("become");
            ignoring.Add("becomes");
            ignoring.Add("becoming");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("beforehand");
            ignoring.Add("behind");
            ignoring.Add("being");
            ignoring.Add("below");
            ignoring.Add("beside");
            ignoring.Add("besides");
            ignoring.Add("between");
            ignoring.Add("beyond");
            ignoring.Add("both");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("cannot");
            ignoring.Add("could");
            ignoring.Add("did");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("done");
            ignoring.Add("down");
            ignoring.Add("during");
            ignoring.Add("each");
            ignoring.Add("either");
            ignoring.Add("else");
            ignoring.Add("elsewhere");
            ignoring.Add("enough");
            ignoring.Add("etc");
            ignoring.Add("even");
            ignoring.Add("ever");
            ignoring.Add("every");
            ignoring.Add("everyone");
            ignoring.Add("everything");
            ignoring.Add("everywhere");
            ignoring.Add("except");
            ignoring.Add("few");
            ignoring.Add("first");
            ignoring.Add("for");
            ignoring.Add("former");
            ignoring.Add("formerly");
            ignoring.Add("from");
            ignoring.Add("further");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("hence");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("hereafter");
            ignoring.Add("hereby");
            ignoring.Add("herein");
            ignoring.Add("hereupon");
            ignoring.Add("hers");
            ignoring.Add("herself");
            ignoring.Add("him");
            ignoring.Add("himself");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("however");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("indeed");
            ignoring.Add("inside");
            ignoring.Add("instead");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("itself");
            ignoring.Add("last");
            ignoring.Add("later");
            ignoring.Add("latter");
            ignoring.Add("latterly");
            ignoring.Add("least");
            ignoring.Add("less");
            ignoring.Add("lot");
            ignoring.Add("many");
            ignoring.Add("may");
            ignoring.Add("me");
            ignoring.Add("meanwhile");
            ignoring.Add("might");
            ignoring.Add("more");
            ignoring.Add("moreover");
            ignoring.Add("most");
            ignoring.Add("mostly");
            ignoring.Add("much");
            ignoring.Add("must");
            ignoring.Add("my");
            ignoring.Add("myself");
            ignoring.Add("name");
            ignoring.Add("namely");
            ignoring.Add("neither");
            ignoring.Add("never");
            ignoring.Add("nevertheless");
            ignoring.Add("next");
            ignoring.Add("no");
            ignoring.Add("nobody");
            ignoring.Add("none");
            ignoring.Add("noone");
            ignoring.Add("nor");
            ignoring.Add("not");
            ignoring.Add("nothing");
            ignoring.Add("now");
            ignoring.Add("nowhere");
            ignoring.Add("of");
            ignoring.Add("off");
            ignoring.Add("often");
            ignoring.Add("on");
            ignoring.Add("once");
            ignoring.Add("one");
            ignoring.Add("only");
            ignoring.Add("or");
            ignoring.Add("other");
            ignoring.Add("others");
            ignoring.Add("otherwise");
            ignoring.Add("ought");
            ignoring.Add("our");
            ignoring.Add("ours");
            ignoring.Add("ourselves");
            ignoring.Add("out");
            ignoring.Add("outside");
            ignoring.Add("over");
            ignoring.Add("own");
            ignoring.Add("part");
            ignoring.Add("per");
            ignoring.Add("perhaps");
            ignoring.Add("please");
            ignoring.Add("put");
            ignoring.Add("rather");
            ignoring.Add("re");
            ignoring.Add("same");
            ignoring.Add("see");
            ignoring.Add("seem");
            ignoring.Add("seemed");
            ignoring.Add("seeming");
            ignoring.Add("seems");
            ignoring.Add("several");
            ignoring.Add("she");
            ignoring.Add("should");
            ignoring.Add("show");
            ignoring.Add("side");
            ignoring.Add("since");
            ignoring.Add("so");
            ignoring.Add("some");
            ignoring.Add("somehow");
            ignoring.Add("someone");
            ignoring.Add("something");
            ignoring.Add("sometime");
            ignoring.Add("sometimes");
            ignoring.Add("somewhere");
            ignoring.Add("still");
            ignoring.Add("such");
            ignoring.Add("take");
            ignoring.Add("than");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("theirs");
            ignoring.Add("them");
            ignoring.Add("themselves");
            ignoring.Add("then");
            ignoring.Add("thence");
            ignoring.Add("there");
            ignoring.Add("thereafter");
            ignoring.Add("thereby");
            ignoring.Add("therefore");
            ignoring.Add("therein");
            ignoring.Add("thereupon");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("those");
            ignoring.Add("though");
            ignoring.Add("through");
            ignoring.Add("throughout");
            ignoring.Add("thru");
            ignoring.Add("thus");
            ignoring.Add("till");
            ignoring.Add("to");
            ignoring.Add("together");
            ignoring.Add("too");
            ignoring.Add("toward");
            ignoring.Add("towards");
            ignoring.Add("under");
            ignoring.Add("unless");
            ignoring.Add("until");
            ignoring.Add("up");
            ignoring.Add("upon");
            ignoring.Add("us");
            ignoring.Add("used");
            ignoring.Add("very");
            ignoring.Add("via");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("well");
            ignoring.Add("were");
            ignoring.Add("what");
            ignoring.Add("whatever");
            ignoring.Add("when");
            ignoring.Add("whence");
            ignoring.Add("whenever");
            ignoring.Add("where");
            ignoring.Add("whereafter");
            ignoring.Add("whereas");
            ignoring.Add("whereby");
            ignoring.Add("wherein");
            ignoring.Add("whereupon");
            ignoring.Add("wherever");
            ignoring.Add("whether");
            ignoring.Add("which");
            ignoring.Add("while");
            ignoring.Add("whither");
            ignoring.Add("who");
            ignoring.Add("whoever");
            ignoring.Add("whole");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("within");
            ignoring.Add("without");
            ignoring.Add("would");
            ignoring.Add("yes");
            ignoring.Add("yet");
            ignoring.Add("you");
            ignoring.Add("your");
            ignoring.Add("yours");
            ignoring.Add("yourself");
            ignoring.Add("yourselves");

        }//end of method words

        public void answers(ArrayList add_answers)
        {//start of method

            
            add_answers.Add("greeting i'm doing well, thanks for asking! how are you doing today ?");
            add_answers.Add("greeting i'm great today, thanks for asking! how can i help you today ?");
            add_answers.Add("greeting doing good! hope you are also doing well today ?");
            add_answers.Add("greeting hello there! i'm ready to help with your security questions.");
            add_answers.Add("greeting hi! glad to chat with you today. what's on your mind ?");
            add_answers.Add("greeting greetings! hope your day is going securely and well.");

            add_answers.Add("my purpose is to educate you on how to stay safe online and guide your cybersecurity questions.");
            add_answers.Add("purpose i help users understand online safety and digital protection.");
            add_answers.Add("purpose i assist with cybersecurity awareness and safety guidance.");
            add_answers.Add("purpose my goal is to break down complex cybersecurity topics into simple safety tips.");
            add_answers.Add("purpose i'm designed to be your go-to assistant for digital security awareness.");
            add_answers.Add("purpose i provide clear advice to help you spot online risks and stay protected.");

            add_answers.Add("cybersecurity is about protecting systems and networks from digital threats.");
            add_answers.Add("cybersecurity it involves protecting devices and online accounts from attacks.");
            add_answers.Add("cybersecurity it focuses on securing digital information and systems.");
            add_answers.Add("cybersecurity think of it as digital self-defense for your files, identity, and hardware.");
            add_answers.Add("cybersecurity it involves using good habits and tools to keep hackers away from data.");
            add_answers.Add("cybersecurity it is the practice of protecting internet-connected devices from malicious attacks.");

            add_answers.Add("phishing is a scam where attackers pretend to be trusted sources to steal information.");
            add_answers.Add("phishing it uses fake messages or websites to trick users into revealing sensitive data.");
            add_answers.Add("phishing attackers use deception to make users believe they are legitimate.");
            add_answers.Add("phishing check sender emails carefully because phishing relies on tricking you into clicking links.");
            add_answers.Add("phishing fake urgent deadlines or weird payment requests are classic signs of a phishing scam.");
            add_answers.Add("phishing always double-check URLs before typing passwords, as phishing sites mimic real ones.");

            add_answers.Add("a firewall controls network traffic based on security rules.");
            add_answers.Add("firewall it helps block unwanted access to your device or network.");
            add_answers.Add("firewall it acts as a protective barrier between trusted and untrusted networks.");
            add_answers.Add("firewall it monitors data coming in and out of your system to block cyber threats.");
            add_answers.Add("firewall keeping your system firewall turned on is a fundamental step in device safety.");
            add_answers.Add("firewall it acts as a digital security guard inspecting all incoming internet connections.");

            add_answers.Add("a password is used to secure access to your accounts or devices.");
            add_answers.Add("password it should be strong, long and not easy to guess.");
            add_answers.Add("password avoid using personal details when creating one.");
            add_answers.Add("password a strong password mixes uppercase letters, numbers, and symbols.");
            add_answers.Add("password using a unique passphrase for every single account stops a chain-reaction hack.");
            add_answers.Add("password never reuse old passwords, and consider using a reliable password manager.");

            add_answers.Add("hacked account immediately secure your account and log out of all devices.");
            add_answers.Add("hacked account contact support if your account has been compromised.");
            add_answers.Add("hacked account enable extra security like two-factor authentication.");
            add_answers.Add("hacked account update your recovery email and phone number immediately if you suspect a breach.");
            add_answers.Add("hacked account alert your close contacts so they know not to click links sent from your profile.");
            add_answers.Add("hacked account check your account settings for any strange login locations or unrecognized devices.");

            add_answers.Add("fraud contact your bank immediately if fraud is detected.");
            add_answers.Add("fraud report suspicious financial activity to the authorities.");
            add_answers.Add("fraud monitor your accounts for unusual activity.");
            add_answers.Add("fraud never share your banking PIN or OTP with anyone, even if they claim to be from your bank.");
            add_answers.Add("fraud digital fraud often starts with too-good-to-be-true offers or sudden prizes.");
            add_answers.Add("fraud report unauthorized card charges straight away to freeze your accounts and stop losses.");

            add_answers.Add("malicious chatbot malicious bots often create urgency to trick users.");
            add_answers.Add("malicious chatbot fake chatbots may ask for sensitive information.");
            add_answers.Add("malicious chatbot be cautious if a bot pressures you for personal data.");
            add_answers.Add("malicious chatbot if an unknown chatbot asks for login credentials, close the window immediately.");
            add_answers.Add("malicious chatbot fake bots try to look helpful while quietly downloading malware onto your machine.");
            add_answers.Add("malicious chatbot only interact with verified chatbots on official, secure company web pages.");

            add_answers.Add("vpn a vpn helps protect your privacy on public wi-fi.");
            add_answers.Add("vpn it encrypts your internet traffic for safety.");
            add_answers.Add("vpn it improves security when using public networks.");
            add_answers.Add("vpn a virtual private network hides your IP address to keep your browsing private.");
            add_answers.Add("vpn it creates a secure, encrypted tunnel for your data to travel through safely.");
            add_answers.Add("vpn using a vpn is highly recommended if you work from public coffee shops or airports.");



            //sentiment detection

            add_answers.Add("frustrated i understand you're frustrated. let's work through the issue step by step.");
            add_answers.Add("frustrated it's okay to feel frustrated when things aren't working. i'm here to help.");
            add_answers.Add("frustrated take a breath, we'll fix this together.");
            add_answers.Add("frustrated technology can be incredibly annoying. let's slow down and figure it out.");
            add_answers.Add("frustrated i hear you. let's handle this one piece at a time so it feels less overwhelming.");
            add_answers.Add("frustrated don't worry, bugs and errors happen to everyone. we will get past this.");

            add_answers.Add("confused that's okay, confusion is normal. i'll explain it clearly for you.");
            add_answers.Add("confused let me break it down step by step so it makes sense.");
            add_answers.Add("confused no worries, i'll help you understand it better.");
            add_answers.Add("confused completely fine! let's look at this from a different angle to make it clearer.");
            add_answers.Add("confused cyber security has a lot of jargon. tell me which part sounds confusing.");
            add_answers.Add("confused let's hit reset. i will explain the concept using a simpler example.");


            add_answers.Add("worried it's okay to feel worried. i'm here to help you stay safe online.");
            add_answers.Add("worried don't panic, most cybersecurity issues can be fixed quickly.");
            add_answers.Add("worried i understand your concern. let's make sure your information is safe.");
            add_answers.Add("worried take a deep breath. identifying the problem is the first step to making it safe.");
            add_answers.Add("worried your concern is completely valid, but we have solid steps to protect you here.");
            add_answers.Add("worried try not to panic. let's focus on securing your data right now.");

            add_answers.Add("happy that's great to hear! i'm glad things are going well.");
            add_answers.Add("happy awesome! positivity is always good.");
            add_answers.Add("happy i'm happy for you! let me know if you need anything.");
            add_answers.Add("happy love that energy! let's keep this positive momentum moving forward.");
            add_answers.Add("happy awesome! safe browsing habits definitely call for a celebration.");
            add_answers.Add("happy hearing that makes my digital day! how else can i keep you smiling ?");

            add_answers.Add("sad i'm sorry you're feeling this way. i'm here for you.");
            add_answers.Add("sad that sounds tough, take things one step at a time.");
            add_answers.Add("sad i hope things improve soon. you can talk to me anytime.");
            add_answers.Add("sad sending you good vibes. remember to be kind to yourself today.");
            add_answers.Add("sad sorry to hear things are rough. i'm right here if you want to keep chatting.");
            add_answers.Add("sad it's perfectly okay to have down days. take all the time you need.");

            add_answers.Add("angry i understand you're angry. let's try solve the issue together.");
            add_answers.Add("angry it's okay to feel angry, but i'll help you fix the problem.");
            add_answers.Add("angry take your time, i'm here to help you sort it out.");
            add_answers.Add("angry your anger makes total sense if security failed you. let's see how we can secure it now.");
            add_answers.Add("angry dealing with these issues is incredibly stressful. i am fully here to help you resolve it.");
            add_answers.Add("angry let's channel that energy into locking down your system and fixing the issue.");

        }//end of method

    }//start of public class respond
}//end of namespace