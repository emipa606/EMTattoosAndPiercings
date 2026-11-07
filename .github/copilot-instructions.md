# EM Tattoos and Piercings (Continued) GitHub Copilot Instructions
## Mod Overview and Purpose EM Tattoos and Piercings (Continued) is an update to Mosh's original mod, adding new traits for body-mod enthusiasts and purists, as well as compatibility with the Scarification mod. The mod also introduces new surgeries that only show up if there are available materials, support for trait values, and alternate recipes using resources from other mods.
## Key Features and Systems The mod adds new traits to the game that allow players to have a deeper connection to their body modifications. The BodyModificationEnthusiast trait increases the chances of a successful operation, while the BodyModificationPurist trait reduces the chances of complications.
The mod also introduces new surgeries that require materials found in the game, such as pigments crafted at a pigment pit. Each surgery offers various strengths and drawbacks, and players must weigh the risks and rewards.
Additionally, the mod adds new jewelry that can be crafted at a campfire and installed as surgery, offering small bonuses. Necklaces and belts can be crafted and worn as normal.
## Coding Patterns and Conventions The mod follows the standard RimWorld modding conventions, with C# files for game logic and XML files for game definitions. The code is organized into different files based on functionality, with each file containing a specific class or method.
## XML Integration The mod uses XML files to define game elements such as hediff definitions, thing category definitions, and recipe definitions. These files are located in the `Defs` folder within the mod directory.
## Harmony Patching The mod uses Harmony patching to modify existing game logic. For example, the `UpdateHediffs` method is patched to update the player's hediffs based on their body modifications.
## Suggestions for Copilot GitHub Copilot can be a useful tool for modding RimWorld. Here are some suggestions for using Copilot to develop this mod:

  * Use Copilot to generate code for new features and systems, such as the new traits and surgeries.
  * Use Copilot to generate XML definitions for new game elements, such as hediff definitions and recipe definitions.
  * Use Copilot to generate Harmony patches for modifying existing game logic.
  * Use Copilot to generate unit tests for the mod's code.

Overall, EM Tattoos and Piercings (Continued) is a fun and engaging mod that adds a new dimension to the game. By following the coding patterns and conventions of RimWorld and using tools like GitHub Copilot, developers can create high-quality mods that enhance the gameplay experience for players.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

