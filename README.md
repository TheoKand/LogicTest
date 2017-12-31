# LogicTest
The Liar and the Truth Teller

There are two guards and two doors. One door leads to freedom, and the other to death. One guard always lies, the other always tells the truth. They know which they are. They know where the two doors go. You do not know which guard is which or which door is which. You may ask one yes or no question. What do you ask to determine which door leads to freedom?

We must ask a question that will result in an answer which is conclusive regardless of the configuration, i.e. if we are asking the liar or the truth teller and if they are guarding the door that leads to freedom or the other door. The solution is to point to any door and ask the guard in front of it: “What will the other guard say if I ask him whether he will use this door?” This question will produce a conclusive answer in all configurations. If you always do the opposite of what the answer says (use the other door) you will always find freedom.

There are four possible configurations, and the answer we get (or it's opposite) must lead to freedom in all cases:
<ol><li>Ask the truth teller that guards the right door</li>
<li>Ask the liar that guards the right door</li>
<li>Ask the truth teller that guards the wrong door</li>
<li>Ask the liar that guards the wrong door</li>
</ol>

<ul>
<li>Run the console application for a visual representation of the results. Two questions are evaluated :
<ol><li>Will you go through this door? (no conclusive answer - wrong question)</li>
<li>What will the other guard answer if I ask him 'Will you go through this door?' (conclusive answer - doing the opposite will always lead to freedom)</li></ol>
</li>
<li>The test suite contains unit tests that check if a question will provide a conclusive answer, and if following this answer (or it's opposite) will lead to freedom, in all possible configurations.</li>
</ul>