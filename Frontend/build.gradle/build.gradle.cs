apply plugin: 'java'

repositories
{
  mavenCentral()
}

dependencies
{
  testCompile 'junit:junit:4.12'
}

test
{
  testLogging {
    events 'passed', 'skipped', 'failed'
    }
}
