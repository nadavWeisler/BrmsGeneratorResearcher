<style>
    .dont { color:red; font-weight: bold; }
    .dont:before {
        content: 'X ';
    }
    .do { color: green; font-weight: bold; }
    .do::before, .consider:before {
        content: 'âœ“ ';
    }
    .consider { color: blue; font-weight: bold; }
    .avoid { color: orange; font-weight: bold; }
    td strong { color: green; }
    .monospace { font-family: Courier; }
</style>

<br />

PopUpResearcher is a desktop application which generates bRMS experiments.
PopUpResearcher responsible for JSON experiment file creation, which intended to be upload to PopUpWeb.
