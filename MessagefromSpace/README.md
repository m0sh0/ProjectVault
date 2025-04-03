# 🚀 Message from Space

Welcome to **Message from Space**! 🛰️  
You have received an encrypted message from outer space, and your task is to decrypt it following specific rules.

## 📜 Problem Statement

The encrypted message consists of **capital letters, numbers, and brackets**. To decrypt it, follow these rules:

1. The message contains only uppercase letters (`A-Z`), numbers (`0-9`), and brackets (`[]`).
2. If a block of text appears inside brackets followed by a number, such as `[AB3]`, you must **repeat** the content inside the brackets **N times** (`ABABAB`).
3. Messages can have **nested blocks**, meaning you must handle multiple layers of decoding.
4. The final output should contain **only capital letters**.

---

## 🧩 Examples

```python
spaceMessage("ABCD")
# Output: "ABCD"

spaceMessage("AB[3CD]")
# Breakdown:
# - "AB" → "AB"
# - "[3CD]" → "CDCDCD"
# - Combined → "ABCDCDCD"
# Output: "ABCDCDCD"

spaceMessage("IF[2E]LG[5O]D")
# Breakdown:
# - "[2E]" → "EE"
# - "[5O]" → "OOOOO"
# - Combined → "IFEELGOOOOOD"
# Output: "IFEELGOOOOOD"
