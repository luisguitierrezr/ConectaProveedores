namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (5WlGKdSc10SbmZJKsPkxZw)
///  <code>RC_78d280d051de27b530ad92d3c1147e6a</code> that represent
/// s <code>GetCountByRoleAndRegionIdRecord</code> <p>Description: </p>
/// </summary>
// Name: GetCountByRoleAndRegionIdRecord
public partial struct RC_78d280d051de27b530ad92d3c1147e6a : ITypedRecord<RC_78d280d051de27b530ad92d3c1147e6a> {
internal static readonly GlobalObjectKey IdGetCountByRoleAndRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0IDSeN5RtScwrZLTwRR+ag");

public ST_03d295412275516fd72842ddfab4d69aStructure ssSTGetCountByRoleAndRegionId;


public static implicit operator ST_03d295412275516fd72842ddfab4d69aStructure( RC_78d280d051de27b530ad92d3c1147e6a r) {
return r.ssSTGetCountByRoleAndRegionId;
}

public static implicit operator RC_78d280d051de27b530ad92d3c1147e6a (ST_03d295412275516fd72842ddfab4d69aStructure r) {
RC_78d280d051de27b530ad92d3c1147e6a res = new RC_78d280d051de27b530ad92d3c1147e6a ();
res.ssSTGetCountByRoleAndRegionId = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_78d280d051de27b530ad92d3c1147e6a() {
OptimizedAttributes = null;
ssSTGetCountByRoleAndRegionId = new ST_03d295412275516fd72842ddfab4d69aStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTGetCountByRoleAndRegionId.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTGetCountByRoleAndRegionId.Read( r, ref index);
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
public void ReadIM(RC_78d280d051de27b530ad92d3c1147e6a r) {
this = r;
}


public static bool operator == (RC_78d280d051de27b530ad92d3c1147e6a a, RC_78d280d051de27b530ad92d3c1147e6a b) {
if (a.ssSTGetCountByRoleAndRegionId != b.ssSTGetCountByRoleAndRegionId) return false;
return true;
}

public static bool operator != (RC_78d280d051de27b530ad92d3c1147e6a a, RC_78d280d051de27b530ad92d3c1147e6a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_78d280d051de27b530ad92d3c1147e6a)) return false;
return (this == (RC_78d280d051de27b530ad92d3c1147e6a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTGetCountByRoleAndRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTGetCountByRoleAndRegionId.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTGetCountByRoleAndRegionId.InternalRecursiveSave();
}


public RC_78d280d051de27b530ad92d3c1147e6a Duplicate() {
RC_78d280d051de27b530ad92d3c1147e6a t;
t.ssSTGetCountByRoleAndRegionId = (ST_03d295412275516fd72842ddfab4d69aStructure)this.ssSTGetCountByRoleAndRegionId.Duplicate();
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
if (head == "getcountbyroleandregionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GetCountByRoleAndRegionId")) variable.Value = ssSTGetCountByRoleAndRegionId; else variable.Optimized = true;
variable.SetFieldName("getcountbyroleandregionid");
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
if (key == IdGetCountByRoleAndRegionId) {
return ssSTGetCountByRoleAndRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdGetCountByRoleAndRegionId.Key.AsGuid) {
return ssSTGetCountByRoleAndRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTGetCountByRoleAndRegionId.FillFromOther((IRecord) other.AttributeGet(IdGetCountByRoleAndRegionId));
}
} // RC_78d280d051de27b530ad92d3c1147e6a
/// <summary>
/// RecordList type <code>GetCountByRoleAndRegionIdRecordList</code> that represents a record list of
///  <code>GetCountByRoleAndRegionId</code>
/// </summary>
public partial class RL_404ae675a6afeae3589ddbd4650eae3a : GenericRecordList<RC_78d280d051de27b530ad92d3c1147e6a>, IEnumerable, IEnumerator {

protected override RC_78d280d051de27b530ad92d3c1147e6a GetElementDefaultValue() {
return new RC_78d280d051de27b530ad92d3c1147e6a();
}

public T[] ToArray<T>(Func<RC_78d280d051de27b530ad92d3c1147e6a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_404ae675a6afeae3589ddbd4650eae3a recordList, Func<RC_78d280d051de27b530ad92d3c1147e6a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_404ae675a6afeae3589ddbd4650eae3a(RC_78d280d051de27b530ad92d3c1147e6a[] array) {
  RL_404ae675a6afeae3589ddbd4650eae3a result = new RL_404ae675a6afeae3589ddbd4650eae3a();
result.InnerFromArray(array);
    return result;
}

public static RL_404ae675a6afeae3589ddbd4650eae3a ToList<T>(T[] array, Func <T, RC_78d280d051de27b530ad92d3c1147e6a> converter) {
  RL_404ae675a6afeae3589ddbd4650eae3a result = new RL_404ae675a6afeae3589ddbd4650eae3a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_404ae675a6afeae3589ddbd4650eae3a FromRestList<T>(RestList<T> restList, Func <T, RC_78d280d051de27b530ad92d3c1147e6a> converter) {
  RL_404ae675a6afeae3589ddbd4650eae3a result = new RL_404ae675a6afeae3589ddbd4650eae3a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_404ae675a6afeae3589ddbd4650eae3a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_78d280d051de27b530ad92d3c1147e6a> NewList() {
return new RL_404ae675a6afeae3589ddbd4650eae3a();
}


} // RL_404ae675a6afeae3589ddbd4650eae3a
}

