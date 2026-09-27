# bRMS Generator Researcher

Windows desktop application that generates breaking repeated masking suppression (bRMS) experiments for Green Lab, a psychology laboratory at the Hebrew University of Jerusalem. Nadav Weisler wrote the program. The Sphinx pages in this repository also describe it as created for Ran Hassin's lab at the Hebrew University.

This repository is the researcher half of the bRMS generator. The application writes a JSON experiment file for upload to the separate bRMS runner. Repeated masking suppression interleaves masks with a lower-contrast target so the target can stay below awareness for an extended time. In breaking RMS the target is shown long enough to become visible, and reaction time measures that breaking time. Paradigm notes, the researcher workflow, and the MIT license text are in the Sphinx sources (`index.rst`, `overview.rst`, `about.rst`, `researcher.rst`, `install.rst`, and `license.rst`).

## Build and run on Windows

`BrmsGeneratorResearcher` is a Windows Forms program. `PopUp_Researcher/BrmsGeneratorResearcher.csproj` targets .NET Framework 4.7.2 and sets `OutputType` to `WinExe`. `PopUp_Researcher.sln` is a Visual Studio 2019 solution.

1. On Windows, install Visual Studio 2019 or a later version that can open this solution, including the .NET desktop development workload and the .NET Framework 4.7.2 developer pack.
2. Open `PopUp_Researcher.sln`.
3. Restore NuGet packages. Dependencies are listed in `PopUp_Researcher/packages.config`. The `packages` directory is not stored in git.
4. Build the Release configuration.
5. Run `PopUp_Researcher\bin\Release\BrmsGeneratorResearcher.exe`. The machine that runs the executable needs .NET Framework 4.7.2.

NuGet restore follows `packages.config`. Two reference paths in the project file differ from that list: SharpCompress is referenced from `packages\SharpCompress.0.23.0\` while `packages.config` lists 0.29.0, and `System.Text.RegularExpressions` is referenced as 4.3.0 while `packages.config` lists 4.3.1.

Release tags through `1.2` include a packaged zip. `install.rst` describes that download. Tag `1.2.1` is the archival snapshot of this repository tip for Zenodo. Packaged application zips remain the assets on tags through `1.2`.

## License

MIT License. See [LICENSE](LICENSE). Copyright (c) 2019 Nadav Weisler.

## Citation

Cite this software with [CITATION.cff](CITATION.cff). That file intentionally has no DOI. Zenodo assigns a DOI when it archives a GitHub release. [.zenodo.json](.zenodo.json) supplies the metadata Zenodo reads for that archive. When both files are present, Zenodo uses `.zenodo.json` and ignores `CITATION.cff` for the archived record. GitHub's cite dialog still reads `CITATION.cff`.
