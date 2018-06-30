# MiniRegex

So, I was given the problem of creating a miniature regular expression parser that could determine pattern matches like this:

`t2s` matches **this** but not **that**

In other words, letters must match exactly, but (single-digit) numbers match that number of any character. Thus `t2s` means: match the letter `t` followed by two of any character, followed by the letter `s`.

During the interview, I couldn't do it. We were working in [CoderPad.io](https://coderpad.io/), which is a really neat tool, by the way. I had done one programming challenge already pretty easily, but on this problem I got stumped. I wanted to do it here mainly as a matter of pride, even though it's irrelevant to the potential employer.

- Implementation: [MiniRegex.cs](https://github.com/adamosoftware/MiniRegex/blob/master/MiniRegex/MiniRegex.cs)
- Tests: [AllTests.cs](https://github.com/adamosoftware/MiniRegex/blob/master/Tests/AllTests.cs)
