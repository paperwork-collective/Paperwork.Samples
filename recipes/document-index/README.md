# Build a document index

A report with a contents page that links to each section and shows the page it starts on.

This is the sample for the [Build a document index](https://paperwork.help/recipes/document-index.html) recipe in the Paperwork help.

## Files

- `report.html`: the layout. Each section has an id, and the contents use `<page for="#id" />` for the page number.
- `report.json`: the data, four sections each with an id, a title and some text.

## Run it

```bash
paperwork generate --layout report.html --data report=report.json --output report.pdf
```


## Learn more

The full walk-through is on the help site: [Build a document index](https://paperwork.help/recipes/document-index.html). The [Paperwork CLI](https://www.nuget.org/packages/Paperwork.CLI) and [Paperwork.Core](https://github.com/paperwork-collective/Paperwork.Core) make documents from these files.
