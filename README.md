# Ecoconcrete

This software proposed an vb.net interface to use the CIPM alogrithm with a SQL database for the materials. 

## Getting Started

The code is written in vb.net and need vb.net editor to be modified.

### Prerequisites

The SQL database is installed on a private server and need access. Contact by email thomas.sanchez@gci.ulaval.ca for access if you are a Laval University member.
You can also create your own database in local and replace the line in DBConnexion.vb :         
Connexion.ConnectionString = "Data Source = 132.203.36.238;Initial Catalog=\\GCI-DACON-01\ECOCONCRETE\DATABASE\MATERIALS.MDF;Integrated Security=True"
by the your database file path.

## Contributing

Please read [CONTRIBUTING.md](https://github.com/TSanch/EcoConcrete/blob/master/CONTRIBUTING.md) for details on the code of conduct, and the process for submitting pull requests.

## Versioning

SemVer is used for versioning. For the versions available, see the tags on this repository. 

## Authors

* **Thomas Sanchez** - *Initial work. Graphical interface in vb.net and connection to sql database* - [TSanch](https://github.com/TSanch)

## License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE.md](https://github.com/TSanch/EcoConcrete/blob/master/LICENSE.md) file for details

## Acknowledgments

CIPM algorithm : [Design of Ecological Concrete by Particle Packing Optimization, S.A.A.M. Fennis, 2011] (https://repository.tudelft.nl/islandora/object/uuid%3A5a1e445b-36a7-4f27-a89a-d48372d2a45c)

