# OldPhonePad

This project simulates an old-style mobile phone keypad where each digit maps to multiple letters.

### How it Works
- Numbers `2–9` map to letters (e.g., `2 → A B C`).
- Pressing a number multiple times cycles through letters.
- `*` acts as a backspace (delete).
- Space `" "` commits the current character.
- `#` indicates the end of input.

### Examples
```csharp
OldPhonePad("33#") => "E"
OldPhonePad("227*#") => "B"
OldPhonePad("4433555 555666#") => "HELLO"
OldPhonePad("8 88777444666*664#") => "TURING"