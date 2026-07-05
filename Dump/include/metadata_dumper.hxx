#ifndef METADATA_DUMPER_H
#define METADATA_DUMPER_H

#include <cstddef>
#include <cstdint>
#include <string>

bool DumpMetadataCsFromFile( const std::string & metadataPath,
    const std::string & outputBaseDir );

#endif // METADATA_DUMPER_H
