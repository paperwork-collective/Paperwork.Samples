# Style alternating columns

A sales table where every other column is shaded, with `:nth-child(odd)` and `:nth-child(even)`.

This is the sample for the [Style alternating columns](https://paperwork.help/recipes/alternating-columns.html) recipe in the Paperwork help.

## Files

- `sales.html`: the layout and its styles.
- `sales.json`: sales by region for four quarters.

## Run it

```bash
paperwork generate --layout sales.html --data sales=sales.json --output sales.pdf
```


## Learn more

The full walk-through is on the help site: [Style alternating columns](https://paperwork.help/recipes/alternating-columns.html). The [Paperwork CLI](https://www.nuget.org/packages/Paperwork.CLI) and [Paperwork.Core](https://github.com/paperwork-collective/Paperwork.Core) make documents from these files.
