namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvGroupOperation.xml' path='doc/member[@name="SpvGroupOperation"]/*' />
public enum SpvGroupOperation
{
    /// <include file='SpvGroupOperation.xml' path='doc/member[@name="SpvGroupOperation.SpvGroupOperationReduce"]/*' />
    SpvGroupOperationReduce = 0,

    /// <include file='SpvGroupOperation.xml' path='doc/member[@name="SpvGroupOperation.SpvGroupOperationInclusiveScan"]/*' />
    SpvGroupOperationInclusiveScan = 1,

    /// <include file='SpvGroupOperation.xml' path='doc/member[@name="SpvGroupOperation.SpvGroupOperationExclusiveScan"]/*' />
    SpvGroupOperationExclusiveScan = 2,

    /// <include file='SpvGroupOperation.xml' path='doc/member[@name="SpvGroupOperation.SpvGroupOperationClusteredReduce"]/*' />
    SpvGroupOperationClusteredReduce = 3,

    /// <include file='SpvGroupOperation.xml' path='doc/member[@name="SpvGroupOperation.SpvGroupOperationPartitionedReduceNV"]/*' />
    SpvGroupOperationPartitionedReduceNV = 6,

    /// <include file='SpvGroupOperation.xml' path='doc/member[@name="SpvGroupOperation.SpvGroupOperationPartitionedInclusiveScanNV"]/*' />
    SpvGroupOperationPartitionedInclusiveScanNV = 7,

    /// <include file='SpvGroupOperation.xml' path='doc/member[@name="SpvGroupOperation.SpvGroupOperationPartitionedExclusiveScanNV"]/*' />
    SpvGroupOperationPartitionedExclusiveScanNV = 8,

    /// <include file='SpvGroupOperation.xml' path='doc/member[@name="SpvGroupOperation.SpvGroupOperationMax"]/*' />
    SpvGroupOperationMax = 0x7fffffff,
}
