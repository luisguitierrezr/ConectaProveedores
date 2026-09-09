namespace ssConectaProveedores {
/// <summary>
/// [Structure] GetCountByRoleAndRegionId (cUxuyqvdE0mpxwuupuiKJw)
///  <code>ST_03d295412275516fd72842ddfab4d69aStructure</code> that represent
/// s <code>GetCountByRoleAndRegionId</code> <p>Description: Get Count By Role And RegionId Struct.</p>
/// </summary>
// Name: GetCountByRoleAndRegionId
public partial struct ST_03d295412275516fd72842ddfab4d69aStructure : ITypedRecord<ST_03d295412275516fd72842ddfab4d69aStructure> {
internal static readonly GlobalObjectKey IdCount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+u1rX_UrkUqx+5HHoMTjmw");
internal static readonly GlobalObjectKey IdApplicationRoleID = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*o5R+iCmy8kmN0f5bZyvHaA");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AMSmxP1Xi02yy+9UJtBbDA");

public int ssCount;

public long ssApplicationRoleID;

public long ssRegionId;


public BitArray OptimizedAttributes;

public ST_03d295412275516fd72842ddfab4d69aStructure() {
OptimizedAttributes = null;
ssCount = 0;
ssApplicationRoleID = 0L;
ssRegionId = 0L;
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
ssCount = r.ReadInteger(index++, "GetCountByRoleAndRegionId.Count", 0);
ssApplicationRoleID = r.ReadEntityReferenceLongInteger(index++, "GetCountByRoleAndRegionId.ApplicationRoleID", 0L);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "GetCountByRoleAndRegionId.RegionId", 0L);
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
public void ReadIM(ST_03d295412275516fd72842ddfab4d69aStructure r) {
this = r;
}


public static bool operator == (ST_03d295412275516fd72842ddfab4d69aStructure a, ST_03d295412275516fd72842ddfab4d69aStructure b) {
if (a.ssCount != b.ssCount) return false;
if (a.ssApplicationRoleID != b.ssApplicationRoleID) return false;
if (a.ssRegionId != b.ssRegionId) return false;
return true;
}

public static bool operator != (ST_03d295412275516fd72842ddfab4d69aStructure a, ST_03d295412275516fd72842ddfab4d69aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_03d295412275516fd72842ddfab4d69aStructure)) return false;
return (this == (ST_03d295412275516fd72842ddfab4d69aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCount.GetHashCode()
 ^ ssApplicationRoleID.GetHashCode()
 ^ ssRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_03d295412275516fd72842ddfab4d69aStructure Duplicate() {
ST_03d295412275516fd72842ddfab4d69aStructure t;
t.ssCount = this.ssCount;
t.ssApplicationRoleID = this.ssApplicationRoleID;
t.ssRegionId = this.ssRegionId;
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
if (head == "count") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Count")) variable.Value = ssCount; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleID")) variable.Value = ssApplicationRoleID; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
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
if (key == IdCount) {
return ssCount;
}
if (key == IdApplicationRoleID) {
return ssApplicationRoleID;
}
if (key == IdRegionId) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCount.Key.AsGuid) {
return ssCount;
}
if (attributeKey == IdApplicationRoleID.Key.AsGuid) {
return ssApplicationRoleID;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCount = (int) other.AttributeGet(IdCount);
ssApplicationRoleID = (long) other.AttributeGet(IdApplicationRoleID);
ssRegionId = (long) other.AttributeGet(IdRegionId);
}
} // ST_03d295412275516fd72842ddfab4d69aStructure
/// <summary>
/// RecordList type <code>GetCountByRoleAndRegionIdList</code> that represents a record list of
///  <code>GetCountByRoleAndRegionId</code>
/// </summary>
public partial class RL_c5348b1a619d6f4ff89d3a1eb602e94d : GenericRecordList<ST_03d295412275516fd72842ddfab4d69aStructure>, IEnumerable, IEnumerator {

protected override ST_03d295412275516fd72842ddfab4d69aStructure GetElementDefaultValue() {
return new ST_03d295412275516fd72842ddfab4d69aStructure();
}

public T[] ToArray<T>(Func<ST_03d295412275516fd72842ddfab4d69aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c5348b1a619d6f4ff89d3a1eb602e94d recordList, Func<ST_03d295412275516fd72842ddfab4d69aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c5348b1a619d6f4ff89d3a1eb602e94d(ST_03d295412275516fd72842ddfab4d69aStructure[] array) {
  RL_c5348b1a619d6f4ff89d3a1eb602e94d result = new RL_c5348b1a619d6f4ff89d3a1eb602e94d();
result.InnerFromArray(array);
    return result;
}

public static RL_c5348b1a619d6f4ff89d3a1eb602e94d ToList<T>(T[] array, Func <T, ST_03d295412275516fd72842ddfab4d69aStructure> converter) {
  RL_c5348b1a619d6f4ff89d3a1eb602e94d result = new RL_c5348b1a619d6f4ff89d3a1eb602e94d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c5348b1a619d6f4ff89d3a1eb602e94d FromRestList<T>(RestList<T> restList, Func <T, ST_03d295412275516fd72842ddfab4d69aStructure> converter) {
  RL_c5348b1a619d6f4ff89d3a1eb602e94d result = new RL_c5348b1a619d6f4ff89d3a1eb602e94d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c5348b1a619d6f4ff89d3a1eb602e94d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_03d295412275516fd72842ddfab4d69aStructure> NewList() {
return new RL_c5348b1a619d6f4ff89d3a1eb602e94d();
}


} // RL_c5348b1a619d6f4ff89d3a1eb602e94d
}

