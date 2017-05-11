namespace _02.Spy_Gram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    // After arriving from the trip from the Splinter Trip problem, our hero Sam is feeling a
    // bit jet lagged, but he’s ready to go to work!He needs to receive orders from his commanding 
    // officers through the sophisticated messaging app, called SpyGram. The app uses a
    // sophisticated algorithm to encrypt messages.Since you’re tired of jumbling text by hand for
    // 8 hours a day, you decide to write an algorithm to do it for you.
    // Sending messages works the following way – an outgoing message must follow the following format:
    // •	TO: {recipient}; MESSAGE: {message};
    // Here’s what an example message looks like: “TO: GOSHO; MESSAGE: hi.;”. If any message is not in
    // this format, you should ignore it.
    // Both parties are given a private key, which consists of digits of a variable length, with
    // which to encrypt/decrypt messages.The encryption algorithm is simple:
    // First, we take the message in the format above, then we shift right the first character of
    // our message by the value of the first character of our private key in the ASCII table, the 
    // second character by the second private key character, and so on.If we run out of characters
    // in our private key(such as when our message is longer than our private key), then we start
    // over from the beginning of our private key.
    // So, with an example message of “hello”, and an example private key of 123, it would look like this:
    // hello -> igomq
    // •	h gets shifted right by 1 character
    // •	e gets shifted right by 2 characters
    // •	l gets shifted right by 3 characters
    // •	l gets shifted right by 1 character (we ran out of characters in the private key and rolled over to the start)
    // •	o gets shifted right by 2 characters.
    // Input
    // The first line of our input consists of our private key.
    // Until we receive the command “END”, we’ll start receiving non-encrypted messages to send to
    // the command center.If we receive a message to send, we need to put it in our pending
    // messages collection.
    // After that, we need to sort the sent messages by sender name in ascending order. 
    // Output
    // To send a message, all we have to do is encrypt it and print it on the console in the
    // standard outgoing message format.
    // Constraints
    // •	All valid recipient/sender names will be UPPERCASE and contain only Latin letters
    // •	Messages can contain ANY ASCII characterExamples
    // Input                                                  Output
    // 13234                                                  UR<#ESFJHV<#OHWTDIH>!vphel#cusvqf#mu>
    // TO: GRIM; MESSAGE: hello;                              UR<#KSLO>$NHUVEHH<#lfonr?
    // TO: ARCHER; MESSAGE: sneak around it;
    // END 

    // Input                                                  Output
    // 142325555                                              US<#MJXYWFP=#OJXXFHI<#ckknwnevlxj@
    // TO: KOBIN; MESSAGE: one two three;                     US<#MTGNS<$OHUXFLJ;$qqg%y|t!xjugj@
    // TO: KESTREL; MESSAGE: affirmative;                     US<#VTRHQBRE\=%RJXTEIH<%qjy(w"jgy%yt!{qum@
    // T: REGAN; MESSAGE: help me;
    // TO: TOMCLANCY; MESSAGE: let's get to work;
    // TO: kestrel; MESSAGE: affirmative;
    // END 

    // Input                                                  Output
    // 82738                                                  \QA#IZEOHZC"TH[[CNHB(cmiqzohwq~gB
    // TO: ARCHER; MESSAGE: affirmative;                      \QA#[IOB#UMUZDOM<'8=-"krvm=
    // FROM: SAM; MESSAGE: i'm pinned down;
    // TO: SAM; MESSAGE: 55% done;
    // FROM: SAM; MESSAGE: infiltrate the storage facility;
    // END	
    public class Message
    {
        public string RecipientName { get; set; }
        public string EncryptedMessage { get; set; }
    }

    public class SpyGram
    {
        public static void Main()
        {
            var pattern = @"(^TO: )([A-Z]+)(; MESSAGE: )(.*?);$";
            var regex = new Regex(pattern);

            var encryptedMessages = new List<Message>();

            var privateKey = Console.ReadLine();
            var inputMessage = Console.ReadLine();

            while (inputMessage != "END")
            {
                if (!regex.IsMatch(inputMessage))
                {
                    goto Input;
                }

                EncryptedMessages(regex, encryptedMessages, privateKey, inputMessage);

                Input:;
                inputMessage = Console.ReadLine();
            }

            foreach (var message in encryptedMessages.OrderBy(x => x.RecipientName))
            {
                Console.WriteLine(message.EncryptedMessage);
            }
        }

        private static void EncryptedMessages(Regex regex, List<Message> encryptedMessages, string privateKey, string inputMessage)
        {
            var encryptedMessage = new StringBuilder();

            var index = 0; // This'll count the Private Key length.

            for (int i = 0; i < inputMessage.Length; i++)
            {
                var chr = inputMessage[i]; // This is the number of the character and the character itself in ASCII.

                if (index == privateKey.Length) 
                {
                    index = 0; // This'll start count the Private Key length again from 0, when we ran out of the length.
                }

                var number = int.Parse(privateKey[index].ToString()); // This'll take the number behind the current Private Key's index.

                chr = (char)((int)chr + number); // Sum the number of the character behind ASCII with the number from the Private Key. 

                encryptedMessage.Append(chr); // Add the new character.

                index++;
            }

            var recipient = regex.Match(inputMessage).Groups[2].Value;

            var message = new Message
            {
                RecipientName = recipient, // Keep the name of the recipient.
                EncryptedMessage = encryptedMessage.ToString() // Keep the encripted message.
            };

            encryptedMessages.Add(message); // Add all messages info in a list, so we could sort them by recipient's name for the output.
        }
    }
}