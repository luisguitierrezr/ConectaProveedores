namespace ssConectaProveedores {
/// <summary>
/// [Structure] ExcelProposalLogToExport (IH23xdRW4UWtlffRz+_TuQ)
///  <code>ST_d9d3688bd2889652b9e8e27acc05ba6cStructure</code> that represent
/// s <code>ExcelProposalLogToExport</code> <p>Description: Excel Log To Export Struct.</p>
/// </summary>
// Name: ExcelProposalLogToExport
public partial struct ST_d9d3688bd2889652b9e8e27acc05ba6cStructure : ITypedRecord<ST_d9d3688bd2889652b9e8e27acc05ba6cStructure> {
internal static readonly GlobalObjectKey IdProposalName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dvnxw8MpHUKQPMn66BLH7A");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aHhls5cSWEGhrocjFvcS2g");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XOGkMvVBwUOAr9er2oDFOw");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*N73MpEBkUUSSArV9O2y6MQ");

public string ssProposalName;

public string ssCreatedBy;

public DateTime ssCreatedOn;

public string ssMessage;


public BitArray OptimizedAttributes;

public ST_d9d3688bd2889652b9e8e27acc05ba6cStructure() {
OptimizedAttributes = null;
ssProposalName = "";
ssCreatedBy = "";
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMessage = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssProposalName = r.ReadText(index++, "ExcelProposalLogToExport.ProposalName", "");
ssCreatedBy = r.ReadText(index++, "ExcelProposalLogToExport.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "ExcelProposalLogToExport.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMessage = r.ReadText(index++, "ExcelProposalLogToExport.Message", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_d9d3688bd2889652b9e8e27acc05ba6cStructure r) {
this = r;
}


public static bool operator == (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure a, ST_d9d3688bd2889652b9e8e27acc05ba6cStructure b) {
if (a.ssProposalName != b.ssProposalName) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure a, ST_d9d3688bd2889652b9e8e27acc05ba6cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure)) return false;
return (this == (ST_d9d3688bd2889652b9e8e27acc05ba6cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssProposalName.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_d9d3688bd2889652b9e8e27acc05ba6cStructure Duplicate() {
ST_d9d3688bd2889652b9e8e27acc05ba6cStructure t;
t.ssProposalName = this.ssProposalName;
t.ssCreatedBy = this.ssCreatedBy;
t.ssCreatedOn = this.ssCreatedOn;
t.ssMessage = this.ssMessage;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "proposalname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalName")) variable.Value = ssProposalName; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalName) {
return ssProposalName;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdMessage) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalName.Key.AsGuid) {
return ssProposalName;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssProposalName = (string) other.AttributeGet(IdProposalName);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_d9d3688bd2889652b9e8e27acc05ba6cStructure
/// <summary>
/// RecordList type <code>ExcelProposalLogToExportList</code> that represents a record list of
///  <code>ExcelProposalLogToExport</code>
/// </summary>
public partial class RL_c548b25bdcfb12c815d629040c2b9cfa : GenericRecordList<ST_d9d3688bd2889652b9e8e27acc05ba6cStructure>, IEnumerable, IEnumerator {

protected override ST_d9d3688bd2889652b9e8e27acc05ba6cStructure GetElementDefaultValue() {
return new ST_d9d3688bd2889652b9e8e27acc05ba6cStructure();
}

public T[] ToArray<T>(Func<ST_d9d3688bd2889652b9e8e27acc05ba6cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c548b25bdcfb12c815d629040c2b9cfa recordList, Func<ST_d9d3688bd2889652b9e8e27acc05ba6cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c548b25bdcfb12c815d629040c2b9cfa(ST_d9d3688bd2889652b9e8e27acc05ba6cStructure[] array) {
  RL_c548b25bdcfb12c815d629040c2b9cfa result = new RL_c548b25bdcfb12c815d629040c2b9cfa();
result.InnerFromArray(array);
    return result;
}

public static RL_c548b25bdcfb12c815d629040c2b9cfa ToList<T>(T[] array, Func <T, ST_d9d3688bd2889652b9e8e27acc05ba6cStructure> converter) {
  RL_c548b25bdcfb12c815d629040c2b9cfa result = new RL_c548b25bdcfb12c815d629040c2b9cfa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c548b25bdcfb12c815d629040c2b9cfa FromRestList<T>(RestList<T> restList, Func <T, ST_d9d3688bd2889652b9e8e27acc05ba6cStructure> converter) {
  RL_c548b25bdcfb12c815d629040c2b9cfa result = new RL_c548b25bdcfb12c815d629040c2b9cfa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c548b25bdcfb12c815d629040c2b9cfa() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d9d3688bd2889652b9e8e27acc05ba6cStructure> NewList() {
return new RL_c548b25bdcfb12c815d629040c2b9cfa();
}


} // RL_c548b25bdcfb12c815d629040c2b9cfa
}

