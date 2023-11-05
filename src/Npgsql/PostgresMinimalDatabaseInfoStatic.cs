using System.Collections.Generic;
using NpgsqlTypes;

namespace Npgsql;

internal static class PostgresMinimalDatabaseInfoStatic
{
    internal static List<BuiltInPostgresType> BuiltInTypes()
    {
        var builtinTypes = new List<BuiltInPostgresType>
        {
            new("int8", 20, 1016),
            new("float8", 701, 1022),
            new("int4", 23, 1007),
            new("numeric", 1700, 1231),
            new("float4", 700, 1021),
            new("int2", 21, 1005),
            new("money", 790, 791),
            new("bool", 16, 1000),
            new("box", 603, 1020),
            new("circle", 718, 719),
            new("line", 628, 629),
            new("lseg", 601, 1018),
            new("path", 602, 1019),
            new("point", 600, 1017),
            new("polygon", 604, 1027),
            new("bpchar", 1042, 1014),
            new("text", 25, 1009),
            new("varchar", 1043, 1015),
            new("name", 19, 1003),
            new("char", 18, 1002),
            new("bytea", 17, 1001),
            new("date", 1082, 1182),
            new("time", 1083, 1183),
            new("timestamp", 1114, 1115),
            new("timestamptz", 1184, 1185),
            new("interval", 1186, 1187),
            new("timetz", 1266, 1270),
            new("inet", 869, 1041),
            new("cidr", 650, 651),
            new("macaddr", 829, 1040),
            new("macaddr8", 774, 775),
            new("bit", 1560, 1561),
            new("varbit", 1562, 1563),
            new("tsvector", 3614, 3643),
            new("tsquery", 3615, 3645),
            new("regconfig", 3734, 3735),
            new("uuid", 2950, 2951),
            new("xml", 142, 143),
            new("json", 114, 199),
            new("jsonb", 3802, 3807),
            new("jsonpath", 4072, 4073),
            new("refcursor", 1790, 2201),
            new("oidvector", 30, 1013),
            new("int2vector", 22, 1006),
            new("oid", 26, 1028),
            new("xid", 28, 1011),
            new("xid8", 5069, 271),
            new("cid", 29, 1012),
            new("regtype", 2206, 2211),
            new("tid", 27, 1010),
            new("pg_lsn", 3220, 3221),
            new("unknown", 705, 0)
        };

        return builtinTypes;
    }
}