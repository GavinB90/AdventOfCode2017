﻿using System;
using System.Diagnostics;


public class Day1Part2
{
    /**
     * Now, instead of considering the next digit, it wants you to consider the digit halfway around the circular list. 
     * That is, if your list contains 10 items, only include a digit in your sum if the digit 10/2 = 5 steps forward matches it. Fortunately, your list has an even number of elements.
     * For example:
     * 1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
     * 1221 produces 0, because every comparison is between a 1 and a 2.
     * 123425 produces 4, because both 2s match each other, but no other digit has a match.
     * 123123 produces 12.
     * 12131415 produces 4.
    **/
    public Day1Part2()
    {
        var inputString = "68376334795224855827459835293967497295464175589881588256882344699473595413912688278647235862566123233983921662578792917453912795352746426512649965615919588512125567186837411371179875287621488759761429629174886972298349197722423458299323141529413191327622485249495864168181327197661454464926326248274999448373741839963155646828842752761293142356422964355349521987483211496361289666375779728345952231649453711684539164893151811849653331845998998597991146881361717234517911759893792348815818755262456378627116779495435596139617246571678531183335956244163871445674244765586446362529159854137535962117184875192273872222899887357292312978286182636232921252574738118347521187637829623831872437381979223955675634257889137823684924127338433248519515211796732599314921611399736571277222546332369461136277417419794865524123989722492356536832313937597437717873787593849468836733642529378547151146397532997237439387663769334722979172954835154486382983716698212694357398153392926255272961384626131829678171219569288685597141132355322788254163923888378155573948753185423158997877718687642446457446643422536541238979761725496426292359382168535641216124211741896552562128941824172241913873537828976172738276983915232241451589421911121567228899853934667954786256223614621554618294467191255153395256524786159758429643756586457639177183891162214163549688595416893383194995824534247841414247526268212761954913719452114876764745799982792594753759626334319631191917894368116738893548797661111899664138398354818931135486984944719992393148681724116616741428937687985152658296679845474766477741553632712968679175356452987459761126437216758171182395219393289199148996813762849991484678429793578629331215796996751484375784895561682156658579887518746862371751372692472765217374791324656745291574784495299477362964676351148183676897122366838656342745944945275263617729359831466565694983217252594237828187612857523344265418227883219383138893873384775659548637662867572687198263688597865118173921615178165442133987362382721444844952715592955744739873677838847693982379696776";
        var input = inputString.ToCharArray();
        // Total sum creating the captcha.
        var captchaSum = 0;
        // Get steps forward number.
        var stepsForward = inputString.Length / 2;
        for (var i = 0; i < input.Length; i++)
        {
            var forwardNumber = 0;
            // As the steps forward needs to wrap around the list this may go out of bounds. Initialise each loop.
            var stepsForwardToUse = stepsForward;
            // Get the current number in the list.
            var currentNumber = int.Parse(input.GetValue(i).ToString());
            if ((i + stepsForward) > inputString.Length - 1)
            {
                // Have to loop the list so we get current number and subtract the length to get the number that will loop around.
                stepsForwardToUse = (i + stepsForward) - inputString.Length;
                forwardNumber = int.Parse(input.GetValue(stepsForwardToUse).ToString());
            }
            else
            {
                forwardNumber = int.Parse(input.GetValue(i + stepsForwardToUse).ToString());
            }

            if (currentNumber == forwardNumber)
            {
                captchaSum += forwardNumber;
            }
        }

        // Output is 1358.
        Debug.WriteLine("Captcha: " + captchaSum);
    }
}
