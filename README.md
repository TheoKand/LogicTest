# The Liar and the Truth Teller

<i>Logic test in C#</i>

<i>I was asked this logic question verbally during a 2nd stage interview for a permanent .NET Developer position with a company in the City of London, in November 2017. The source code implementation in C# is my original work.</i>

There are two guards and two doors. One door leads to freedom, and the other to death. One guard always lies, the other always tells the truth. They know where the two doors go. You do not know which guard is which or which door is which. You may ask one yes or no question to one guard. What do you ask to determine which door leads to freedom?

<p>
<details>
    <summary>SHOW SOLUTION</summary>
    
We must ask a question that will result in an answer which is conclusive regardless of the configuration, i.e. if we are asking the liar or the truth teller and if they are guarding the door that leads to freedom or the other door. 

<b>SOLUTION</B>

Point to any door and ask the guard in front of it: What will the other guard say if I ask him 'Does your door lead to freedom?'. This question will produce a conclusive answer in all configurations. If you always do the opposite of what the answer says (use the other door) you will always find the right door.

There are four possible configurations, and the answer we get (or it's opposite) must lead to the safe door in all cases:
<ol><li>Ask the truth teller that guards the right door</li>
<li>Ask the liar that guards the right door</li>
<li>Ask the truth teller that guards the wrong door</li>
<li>Ask the liar that guards the wrong door</li>
</ol>

<ul>
<li>Run the console application for a visual representation of the results. Two questions are evaluated :
<ol><li>Does your door lead to freedom? (no conclusive answer - wrong question)</li>
<li>What will the other guard answer if I ask him 'Does your door lead to freedom?' (conclusive answer - doing the opposite will always lead to freedom)</li></ol>
</li>
<li>The test suite contains unit tests that check if a question will provide a conclusive answer, and if following this answer (or it's opposite) will lead to freedom, in all possible configurations.</li>
</ul>



</details>
</p>

<p>
There are more "correct" questions than the one provided here. A correct question will provide a conclusive answer regardless of configuration and the answer (or the opposite) will always lead to freedom.
  </p>

