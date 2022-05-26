# User Story - Consolidate global app metdata

As a developer, I have to maintain global app metadata,
like semantic version, product name, copyright info, company info, etc.
in various places like project files (csproj), build files (.props, .targets),
as well on code-level for maintaining attributes, constants values, etc.

It would be great, if this kind of metadata

* can be defined and maintained centrally
* weaved automatically into code

One approach could be the use of the t4 templating system

## Breakdown

* [X] Explore MSBuild inline tasks for generating code
~~* [ ] Explore t4 templates for generating code~~
* [X] Implement code generation based on exploration results
* [X] Identify and define places in code to be automatically maintained
* [X] Update code with generated constants
