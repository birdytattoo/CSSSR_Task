Feature: POST tests

Scenario Outline: Add new superhero
	Given Superhero with name = '<User Name>', birthDate = '<Birth Date>', city = '<City>', mainSkill = '<Main Skil>', gender = '<Gender>', phone = '<Phone>'

	Then Execute query and in response parameter name = '<User Name>', birthDate = '<Birth Date>', city = '<City>', mainSkill = '<Main Skil>', gender = '<Gender>', phone = '<Phone>'

Examples:
| User Name | Birth Date | City     | Main Skill | Gender | Phone        |
| User User | 2020-03-31 | New York | sleep      | M      | +71112223344 |