# MiniRegex

So, I was given the problem of creating a miniature regular expression parser that could determine pattern matches like this:

`t2s` matches **this** but not **that**

In other words, letters must match exactly, but (single-digit) numbers match that number of any character. Thus `t2s` means: match the letter `t` followed by two of any character, followed by the letter `s`.

During the interview, I couldn't do it. We were working in [CoderPad.io](https://coderpad.io/), which is a really neat tool, by the way. I had done one programming challenge already pretty easily, but on this problem I got stumped. I wanted to do it here mainly as a matter of pride, even though it's irrelevant to the potential employer.

- Implementation: [MiniRegex.cs](https://github.com/adamosoftware/MiniRegex/blob/master/MiniRegex/MiniRegex.cs)
- Tests: [AllTests.cs](https://github.com/adamosoftware/MiniRegex/blob/master/Tests/AllTests.cs)

I'm not all that upset since this was not a job I was actively seeking. I suspected it was a very competitive position, and probably would've paid really well. And I could've worked from home.

I am still a bit flustered that I couldn't do something so relatively simple on the spot, however. I am put in mind of Daniel Kahneman's provactive book *Thinking Fast and Slow* which goes into great detail about the two very different modes of thought humans use. I can't remember if it was in that book or another that there's a story of a famous tennis player who did badly at Wimbledon or some other big tournament because she fell into "slow thinking mode" during a match. She got very flustered and was beaten badly.

I can say that one important factor in my case was not working in a full IDE. CoderPad does some neat things, and is a great interviewing tool generally, but the lack of the lack of full IntelliSense made me nervous. It was not very necessary to the problem at hand, since it didn't require any deep class library recollection. But I think I felt like Dumbo without his magic feather. I am used to IntelliSense popups being a reassuring presence while coding, even when they aren't necessary. (I found them problematic while trying to learn Linq years ago -- because of the lambdas and Func<>s you come across in Linq -- IntelliSense tips for Linq were just Greek to me. It meek a very long time to get comfortable with Linq, and IntelliSense was no help.)
