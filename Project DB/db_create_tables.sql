CREATE TABLE "table_spec" (
	"id"	INTEGER NOT NULL UNIQUE,
	"table_name"	TEXT NOT NULL UNIQUE,
	"source_tool"	TEXT NOT NULL,
	"plugin_guid"	TEXT NOT NULL UNIQUE,
	PRIMARY KEY("id" AUTOINCREMENT)
)

CREATE TABLE "expl_review" (
	"vuln_name"	TEXT NOT NULL,
	"vuln_description"	TEXT NOT NULL,
	"first_seen"	TEXT NOT NULL,
	"last_seen"	TEXT NOT NULL,
	"exploit_db"	INTEGER,
	"exploited_by"	TEXT,
	"cvss"	REAL,
	"source_tool"	TEXT NOT NULL,
	"see_also"	TEXT,
	"first_exploited"	TEXT,
	"last_exploited"	TEXT
)

CREATE TABLE "host_review" (
	"ip_address"	TEXT NOT NULL,
	"fqdn"	TEXT,
	"os_guess"	INTEGER,
	"source_tool"	TEXT NOT NULL,
	"first_seen"	TEXT NOT NULL,
	"last_seen"	TEXT NOT NULL
)

CREATE TABLE "port_review" (
	"ip_address"	TEXT NOT NULL,
	"fqdn"	TEXT,
	"protocol"	TEXT NOT NULL,
	"port"	INTEGER NOT NULL,
	"state"	TEXT NOT NULL,
	"service_guess"	TEXT
)

