using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool loop1 = true;
        bool loop2 = true;
        bool loop3 = true;

        while (loop2)
        {
            loop3 = true;
            string halfDNA = Console.ReadLine();
            bool check = IsValidSequence(halfDNA);
            {
                if (check)
                {
                    Console.WriteLine("Current half DNA sequence : {0}", halfDNA);

                    {
                        while (loop1)
                        {
                            Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                            string yesNo = Console.ReadLine();
                            switch (yesNo)
                            {
                                case "Y":
                                    {
                                        string reHalfDNA = ReplicateSeqeunce(halfDNA);
                                        Console.WriteLine("Replicated half DNA sequence : {0}", reHalfDNA);
                                        loop1 = false;
                                        break;
                                    }
                                case "N":
                                    {
                                        loop1 = false;
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Please input Y or N.");
                                        break;
                                    }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }

  
                {
                    while(loop3)
                    {
                        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                        string yesNo2 = Console.ReadLine();
                        switch (yesNo2)
                    {
                        case "Y":
                            {
                                loop1 = true;
                                loop3 = false;
                                break;
                            }
                        case "N":
                            {
                                loop3 = false;
                                loop2 = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Please input Y or N.");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }

    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
}

