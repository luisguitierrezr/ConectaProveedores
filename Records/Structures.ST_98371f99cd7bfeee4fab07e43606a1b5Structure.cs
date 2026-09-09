namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] TimeZoneRecord (Aj7i0LPWiEeyxhVWNhUzew)
///  <code>ST_98371f99cd7bfeee4fab07e43606a1b5Structure</code> that represent
/// s <code>TimeZoneRecord</code> <p>Description: </p>
/// </summary>
// Name: TimeZoneRecord
public partial struct ST_98371f99cd7bfeee4fab07e43606a1b5Structure : ITypedRecord<ST_98371f99cd7bfeee4fab07e43606a1b5Structure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdIdentifier = GlobalObjectKey.Parse("Bl2Dw7lBcPtD8Z6Y2oUzqg*ogO6rxVxuKMXNd4ArCqUBw");
internal static readonly GlobalObjectKey IdStandardName = GlobalObjectKey.Parse("Bl2Dw7lBcPtD8Z6Y2oUzqg*nHwNwUbKapyfuHJDkScy_w");
internal static readonly GlobalObjectKey IdDisplayName = GlobalObjectKey.Parse("Bl2Dw7lBcPtD8Z6Y2oUzqg*hgrM8mEpVulB6+W3V1e3nQ");
internal static readonly GlobalObjectKey IdUtcOffset = GlobalObjectKey.Parse("Bl2Dw7lBcPtD8Z6Y2oUzqg*Ysw0lzxZNfE_HcvGnzJw7g");
internal static readonly GlobalObjectKey IdSupportsDaylightSaving = GlobalObjectKey.Parse("Bl2Dw7lBcPtD8Z6Y2oUzqg*fmaGauwvnC5L2RKq_PNcVg");
internal static readonly GlobalObjectKey IdIsDaylightSaving = GlobalObjectKey.Parse("Bl2Dw7lBcPtD8Z6Y2oUzqg*KtYWL2Uq_00pXl2rsCg1+A");

public string ssIdentifier;

public string ssStandardName;

public string ssDisplayName;

public int ssUtcOffset;

public bool ssSupportsDaylightSaving;

public bool ssIsDaylightSaving;


public BitArray OptimizedAttributes;

public ST_98371f99cd7bfeee4fab07e43606a1b5Structure() {
OptimizedAttributes = null;
ssIdentifier = "";
ssStandardName = "";
ssDisplayName = "";
ssUtcOffset = 0;
ssSupportsDaylightSaving = false;
ssIsDaylightSaving = false;
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
ssIdentifier = r.ReadText(index++, "TimeZoneRecord.Identifier", "");
ssStandardName = r.ReadText(index++, "TimeZoneRecord.StandardName", "");
ssDisplayName = r.ReadText(index++, "TimeZoneRecord.DisplayName", "");
ssUtcOffset = r.ReadInteger(index++, "TimeZoneRecord.UtcOffset", 0);
ssSupportsDaylightSaving = r.ReadBoolean(index++, "TimeZoneRecord.SupportsDaylightSaving", false);
ssIsDaylightSaving = r.ReadBoolean(index++, "TimeZoneRecord.IsDaylightSaving", false);
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
public void ReadIM(ST_98371f99cd7bfeee4fab07e43606a1b5Structure r) {
this = r;
}


public static bool operator == (ST_98371f99cd7bfeee4fab07e43606a1b5Structure a, ST_98371f99cd7bfeee4fab07e43606a1b5Structure b) {
if (a.ssIdentifier != b.ssIdentifier) return false;
if (a.ssStandardName != b.ssStandardName) return false;
if (a.ssDisplayName != b.ssDisplayName) return false;
if (a.ssUtcOffset != b.ssUtcOffset) return false;
if (a.ssSupportsDaylightSaving != b.ssSupportsDaylightSaving) return false;
if (a.ssIsDaylightSaving != b.ssIsDaylightSaving) return false;
return true;
}

public static bool operator != (ST_98371f99cd7bfeee4fab07e43606a1b5Structure a, ST_98371f99cd7bfeee4fab07e43606a1b5Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_98371f99cd7bfeee4fab07e43606a1b5Structure)) return false;
return (this == (ST_98371f99cd7bfeee4fab07e43606a1b5Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssIdentifier.GetHashCode()
 ^ ssStandardName.GetHashCode()
 ^ ssDisplayName.GetHashCode()
 ^ ssUtcOffset.GetHashCode()
 ^ ssSupportsDaylightSaving.GetHashCode()
 ^ ssIsDaylightSaving.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_98371f99cd7bfeee4fab07e43606a1b5Structure Duplicate() {
ST_98371f99cd7bfeee4fab07e43606a1b5Structure t;
t.ssIdentifier = this.ssIdentifier;
t.ssStandardName = this.ssStandardName;
t.ssDisplayName = this.ssDisplayName;
t.ssUtcOffset = this.ssUtcOffset;
t.ssSupportsDaylightSaving = this.ssSupportsDaylightSaving;
t.ssIsDaylightSaving = this.ssIsDaylightSaving;
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
if (head == "identifier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Identifier")) variable.Value = ssIdentifier; else variable.Optimized = true;
} else if (head == "standardname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StandardName")) variable.Value = ssStandardName; else variable.Optimized = true;
} else if (head == "displayname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DisplayName")) variable.Value = ssDisplayName; else variable.Optimized = true;
} else if (head == "utcoffset") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UtcOffset")) variable.Value = ssUtcOffset; else variable.Optimized = true;
} else if (head == "supportsdaylightsaving") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupportsDaylightSaving")) variable.Value = ssSupportsDaylightSaving; else variable.Optimized = true;
} else if (head == "isdaylightsaving") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDaylightSaving")) variable.Value = ssIsDaylightSaving; else variable.Optimized = true;
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
if (key == IdIdentifier) {
return ssIdentifier;
}
if (key == IdStandardName) {
return ssStandardName;
}
if (key == IdDisplayName) {
return ssDisplayName;
}
if (key == IdUtcOffset) {
return ssUtcOffset;
}
if (key == IdSupportsDaylightSaving) {
return ssSupportsDaylightSaving;
}
if (key == IdIsDaylightSaving) {
return ssIsDaylightSaving;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdIdentifier.Key.AsGuid) {
return ssIdentifier;
}
if (attributeKey == IdStandardName.Key.AsGuid) {
return ssStandardName;
}
if (attributeKey == IdDisplayName.Key.AsGuid) {
return ssDisplayName;
}
if (attributeKey == IdUtcOffset.Key.AsGuid) {
return ssUtcOffset;
}
if (attributeKey == IdSupportsDaylightSaving.Key.AsGuid) {
return ssSupportsDaylightSaving;
}
if (attributeKey == IdIsDaylightSaving.Key.AsGuid) {
return ssIsDaylightSaving;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssIdentifier = (string) other.AttributeGet(IdIdentifier);
ssStandardName = (string) other.AttributeGet(IdStandardName);
ssDisplayName = (string) other.AttributeGet(IdDisplayName);
ssUtcOffset = (int) other.AttributeGet(IdUtcOffset);
ssSupportsDaylightSaving = (bool) other.AttributeGet(IdSupportsDaylightSaving);
ssIsDaylightSaving = (bool) other.AttributeGet(IdIsDaylightSaving);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssIdentifier = (string) other.GetAttribute(IdIdentifier.Key.AsGuid);
ssStandardName = (string) other.GetAttribute(IdStandardName.Key.AsGuid);
ssDisplayName = (string) other.GetAttribute(IdDisplayName.Key.AsGuid);
ssUtcOffset = (int) other.GetAttribute(IdUtcOffset.Key.AsGuid);
ssSupportsDaylightSaving = (bool) other.GetAttribute(IdSupportsDaylightSaving.Key.AsGuid);
ssIsDaylightSaving = (bool) other.GetAttribute(IdIsDaylightSaving.Key.AsGuid);
}
} // ST_98371f99cd7bfeee4fab07e43606a1b5Structure
/// <summary>
/// RecordList type <code>TimeZoneRecordList</code> that represents a record list of
///  <code>TimeZoneRecord</code>
/// </summary>
public partial class RL_eaa83d98683988a60076707f28f13a58 : GenericRecordList<ST_98371f99cd7bfeee4fab07e43606a1b5Structure>, IEnumerable, IEnumerator {

protected override ST_98371f99cd7bfeee4fab07e43606a1b5Structure GetElementDefaultValue() {
return new ST_98371f99cd7bfeee4fab07e43606a1b5Structure();
}

public T[] ToArray<T>(Func<ST_98371f99cd7bfeee4fab07e43606a1b5Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eaa83d98683988a60076707f28f13a58 recordList, Func<ST_98371f99cd7bfeee4fab07e43606a1b5Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eaa83d98683988a60076707f28f13a58(ST_98371f99cd7bfeee4fab07e43606a1b5Structure[] array) {
  RL_eaa83d98683988a60076707f28f13a58 result = new RL_eaa83d98683988a60076707f28f13a58();
result.InnerFromArray(array);
    return result;
}

public static RL_eaa83d98683988a60076707f28f13a58 ToList<T>(T[] array, Func <T, ST_98371f99cd7bfeee4fab07e43606a1b5Structure> converter) {
  RL_eaa83d98683988a60076707f28f13a58 result = new RL_eaa83d98683988a60076707f28f13a58();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eaa83d98683988a60076707f28f13a58 FromRestList<T>(RestList<T> restList, Func <T, ST_98371f99cd7bfeee4fab07e43606a1b5Structure> converter) {
  RL_eaa83d98683988a60076707f28f13a58 result = new RL_eaa83d98683988a60076707f28f13a58();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eaa83d98683988a60076707f28f13a58() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_98371f99cd7bfeee4fab07e43606a1b5Structure> NewList() {
return new RL_eaa83d98683988a60076707f28f13a58();
}


} // RL_eaa83d98683988a60076707f28f13a58
}

