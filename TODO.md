# Money

## Requirements

Previous marketing was all in USD: 

| Instrument | Shares | Price | Total |
|------------|:-------|------:|------:|
| IBM        | 1000   | 25    | 25000 |
| GE         | 400    | 100   | 40000 |
|            |        |-------|-------|
|            |        | Total | 65000 |

**New requirement**: handle multiple currencies:

| Instrument | Shares | Price   | Total     |
|------------|:-------|--------:|----------:|
| IBM        | 1000   | 25 USD  | 25000 USD |
| GE         | 400    | 100 CHF | 40000 CHF |
|            |        |---------|-----------|
|            |        | Total   | 65000 USD |

Our goal:

- multiply money values
- add money values with different currencies

## TODO list

Chapter 12 introduces 'intuition'.

- ~~$5 + 10 CHF = $10 if rate s 2:1~~
- ~~$5 + $5 = $10~~
- Returns Money from $5 + $5
- ~~Bank.Reduce(Money)~~
- ~~Reduce Money with conversion~~
- ~~Reduce(Bank, String)~~
- Sum.Plus
- Expression.Times

### Leftovers from Chapter 1 through Chapter 11

- Money rounding?
- hashCode()
- Equal null
- Equal object
- ~~$5 * 2 = $10~~
- ~~Make "Amount" private~~
- ~~Dollar side effects?~~
- ~~equals()~~
- ~~5 CHF * 2 = 10 CHF~~
- ~~Common equals~~
- ~~Common times~~
- ~~Dollar/Franc duplication~~
- ~~Compare Francs and Dollars~~
- ~~Currency?~~
- ~~Delete FrancMultiplication?~~

### Syntax

The currently active todo item will be highlight in bold. 
Completed items will have the strike through syntax.
Example:

- **working on item a**
- some other item
- ~~this is easy~~
 