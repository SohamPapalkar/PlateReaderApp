# 📘 PlateReader Console App (C# .NET)

A console-based simulation of a microplate reader that selects a wavelength, waits for user actions, reads an 8×12 plate, and displays or saves the data.

---

## 🧩 Features

- ✅ Command-line control for wavelength, wait time, and output
- ✅ Simulated connection to a plate reader
- ✅ Auto-select or user-defined wavelength (e.g., 425, 450, 500)
- ✅ Prompts for plate insert/removal with delay or key press
- ✅ Simulated 8×12 grid readings (rounded to 4 decimals)
- ✅ Output to console, file (`output.txt`), or both

---

## 📥 Input Parameters

Run using:

```bash
dotnet run -- <Wavelength> <WaitTime> <OutputType>
