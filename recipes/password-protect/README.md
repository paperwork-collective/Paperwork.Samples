# Password-protect a PDF

An account statement that is made into a PDF that needs a password to open.

This is the sample for the [Password-protect a PDF](https://paperwork.help/recipes/password-protect.html) recipe in the Paperwork help.

## Files

- `statement.html`: the layout. The customer and the date are fields, and the lines come from the data.
- `statement.json`: the data, the statement lines.

## Run it

Set the password in an environment variable, then make the PDF:

```bash
export STATEMENT_PASSWORD=choose-a-password
paperwork generate \
  --layout statement.html \
  --data statement=statement.json \
  --field customer="Acme Corp" \
  --field statementDate=2026-03-31 \
  --password-env STATEMENT_PASSWORD \
  --output statement.pdf
```

The PDF asks for the password when it is opened.


## Learn more

The full walk-through is on the help site: [Password-protect a PDF](https://paperwork.help/recipes/password-protect.html). The [Paperwork CLI](https://www.nuget.org/packages/Paperwork.CLI) and [Paperwork.Core](https://github.com/paperwork-collective/Paperwork.Core) make documents from these files.
