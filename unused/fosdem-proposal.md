**Writing Game Boy games in Forth**

**Game Boy development in Forth**

**Writing a Forth to Game Boy compiler**

**Using Forth to reverse-engineer Game Boy games**

**GBForth: Using Forth to understand the Game Boy**


### Mix abstract
In this talk we'll get a good understanding of Game Boy programming by
reverse-engineering a ROM using Forth. We go beyond just decompiling the ROM to
assembly and show how we created a cross-compiler that allows writing Game Boy
games in Forth as well. You'll get to see how Forth interacts with the Game Boy
hardware, and how the language can be extended to easily render sprites or
play sounds for example.

We show you how to incrementally refactor bytecode into higher levels of
abstraction. No black boxes. No magic. This way you can understand and
appreciate every layer of the hardware and CPU instructions one by one. A
similar approach can help you understand other systems (NES comes to mind) and create a
language that is more comfortable than ASM or C to work with.

The talk is accessible to developers without former Game Boy, Forth or compiler
experience.


### Abstract Joonas
During this talk we'll get a good understanding of Game Boy programming by
reverse-engineering a ROM using Forth. We go beyond just decompiling the ROM to assembly and show how we created a cross-compiler that allows writing Game Boy games in Forth. You'll get to see how Forth interacts
with the Game Boy hardware and how the language can be extended for example to
easily render sprites and play sounds.

We show you how to incrementally refactor byte code into higher levels of abstraction.
No black boxes. No magic. A similar approach can help you understand other systems
(f.ex. NES) and create a language that is more comfortable than ASM or C to work with.

The talk is accessible to developers without former Game Boy, Forth or compiler experience.



### abstract
*Provide a description of the subject of the talk and the intended
audience (in the "Abstract" field of the "Description" tab)*

> I'll show how to write a Forth cross-compiler for the Game Boy using a very
incremental process, that does not require any specific experience

In this talk we'll get a good understanding of Game Boy programming by
reverse-engineering a ROM using Forth. Going beyond just decompiling to assembly,
we ended up creating a cross-compiler that allows writing Game Boy games in Forth
as well. You'll get to see how Forth interacts with the Game Boy hardware, and
how the language can be extended to easily render sprites or play sounds.

Incrementally refactoring byte code into higher levels of abstraction allows you
to understand and appreciate every layer of the hardware and CPU instructions one
by one. This way you avoid the feeling of anything being a black box or too
"magical". A similar approach could help you understand other systems (NES comes
to mind), and shape and extend a language that is more comfortable to work with
than ASM or C.

Accessible to developers without former Game Boy, Forth or compiler experience.

(Duration can be anywhere between 30-60 minutes -- allowing for some more
interesting hardware/implementation details.)

### full description**
*Provide a rough outline of the talk or goals of the session (a short
list of bullet points covering topics that will be discussed) in the
"Full description" field in the "Description" tab*

- Go through the basics of Game Boy hardware
- Explain how rendering graphics works on a Game Boy
- Outline the challenges of working with the Game Boy memory
- Show how to reverse-engineer a binary using Forth
- Describe the process of writing the cross-compiler
- Talk about using GBForth to write Game Boy games

(Duration can be anywhere between 30-60 minutes -- allowing for some more
interesting details about the hardware/implementation.)

### expected length
*Provide an expected length of your talk in the "Duration" field,
including discussion. The default duration is 30 minutes.*

30 - 50 min






### OLD abstract
In this talk we'll look at an incremental approach of writing a Forth cross-compiler
for the Game Boy; starting from byte code, gradually moving up to higher levels
of abstraction. Working in this way allows you to understand and appreciate every
layer of the CPU and language one by one, without the feeling of anything being
a "magical" black box.

Eventually we end up with a way of writing Game Boy games in a simpler way than
ASM or C provide, with a way to interop with the assembler for
performance-critical code. A similar approach could help you understanding other
systems (NES comes to mind), and provide a way to shape and extend a language
that is comfortable to work with.

Accessible to developers without former Game Boy, Forth or compiler experience.

### OLD description
- Understanding the challenges with the Game Boy hardware
- Seeing why Forth is a great tool for the job
- Knowing how GB game development could look like when going past the assembler
