namespace ssConectaProveedores {
/// <summary>
/// [Structure] RegionsDropdown (IbZLBBWHBE2vCcpYyM7gqA)
///  <code>ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure</code> that represent
/// s <code>RegionsDropdown</code> <p>Description: RegionsDropdown</p>
/// </summary>
// Name: RegionsDropdown
public partial struct ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure : ITypedRecord<ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure> {
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZtADEdQUsEGIZF4yWimhbg");
internal static readonly GlobalObjectKey IdRegionCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2AObiSFMSkqFA0luaFEnCw");
internal static readonly GlobalObjectKey IdRegionName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wn3GXLf+_0ipXL7DsxPIfw");

public long ssRegionId;

public string ssRegionCode;

public string ssRegionName;


public BitArray OptimizedAttributes;

public ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure() {
OptimizedAttributes = null;
ssRegionId = 0L;
ssRegionCode = "";
ssRegionName = "";
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
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "RegionsDropdown.RegionId", 0L);
ssRegionCode = r.ReadText(index++, "RegionsDropdown.RegionCode", "");
ssRegionName = r.ReadText(index++, "RegionsDropdown.RegionName", "");
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
public void ReadIM(ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure r) {
this = r;
}


public static bool operator == (ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure a, ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure b) {
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssRegionCode != b.ssRegionCode) return false;
if (a.ssRegionName != b.ssRegionName) return false;
return true;
}

public static bool operator != (ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure a, ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure)) return false;
return (this == (ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssRegionCode.GetHashCode()
 ^ ssRegionName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure Duplicate() {
ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure t;
t.ssRegionId = this.ssRegionId;
t.ssRegionCode = this.ssRegionCode;
t.ssRegionName = this.ssRegionName;
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
if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "regioncode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionCode")) variable.Value = ssRegionCode; else variable.Optimized = true;
} else if (head == "regionname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionName")) variable.Value = ssRegionName; else variable.Optimized = true;
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
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdRegionCode) {
return ssRegionCode;
}
if (key == IdRegionName) {
return ssRegionName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdRegionCode.Key.AsGuid) {
return ssRegionCode;
}
if (attributeKey == IdRegionName.Key.AsGuid) {
return ssRegionName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssRegionId = (long) other.AttributeGet(IdRegionId);
ssRegionCode = (string) other.AttributeGet(IdRegionCode);
ssRegionName = (string) other.AttributeGet(IdRegionName);
}
} // ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure
/// <summary>
/// RecordList type <code>RegionsDropdownList</code> that represents a record list of
///  <code>RegionsDropdown</code>
/// </summary>
public partial class RL_66e54aa915d6f6db629964a69a34a959 : GenericRecordList<ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure>, IEnumerable, IEnumerator {

protected override ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure GetElementDefaultValue() {
return new ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure();
}

public T[] ToArray<T>(Func<ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_66e54aa915d6f6db629964a69a34a959 recordList, Func<ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_66e54aa915d6f6db629964a69a34a959(ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure[] array) {
  RL_66e54aa915d6f6db629964a69a34a959 result = new RL_66e54aa915d6f6db629964a69a34a959();
result.InnerFromArray(array);
    return result;
}

public static RL_66e54aa915d6f6db629964a69a34a959 ToList<T>(T[] array, Func <T, ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure> converter) {
  RL_66e54aa915d6f6db629964a69a34a959 result = new RL_66e54aa915d6f6db629964a69a34a959();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_66e54aa915d6f6db629964a69a34a959 FromRestList<T>(RestList<T> restList, Func <T, ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure> converter) {
  RL_66e54aa915d6f6db629964a69a34a959 result = new RL_66e54aa915d6f6db629964a69a34a959();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_66e54aa915d6f6db629964a69a34a959() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1d2d09c8b788d410a2c7ddc6277e6c9aStructure> NewList() {
return new RL_66e54aa915d6f6db629964a69a34a959();
}


} // RL_66e54aa915d6f6db629964a69a34a959
}

