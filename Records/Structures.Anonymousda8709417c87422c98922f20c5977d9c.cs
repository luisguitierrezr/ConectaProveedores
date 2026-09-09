namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (QQmH2od8LEKYki8gxZd9nA)
///  <code>RC_46bc538195fa6f6c2cd854e16266e629</code> that represent
/// s <code>ReportSAPStatus_ItemRecord</code> <p>Description: </p>
/// </summary>
// Name: ReportSAPStatus_ItemRecord
public partial struct RC_46bc538195fa6f6c2cd854e16266e629 : ITypedRecord<RC_46bc538195fa6f6c2cd854e16266e629> {
internal static readonly GlobalObjectKey IdReportSAPStatus_Item = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gVO8RvqVbG8s2FThYmbmKQ");

public ST_fc6debbee6469de53c667334dded1d22Structure ssSTReportSAPStatus_Item;


public static implicit operator ST_fc6debbee6469de53c667334dded1d22Structure( RC_46bc538195fa6f6c2cd854e16266e629 r) {
return r.ssSTReportSAPStatus_Item;
}

public static implicit operator RC_46bc538195fa6f6c2cd854e16266e629 (ST_fc6debbee6469de53c667334dded1d22Structure r) {
RC_46bc538195fa6f6c2cd854e16266e629 res = new RC_46bc538195fa6f6c2cd854e16266e629 ();
res.ssSTReportSAPStatus_Item = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_46bc538195fa6f6c2cd854e16266e629() {
OptimizedAttributes = null;
ssSTReportSAPStatus_Item = new ST_fc6debbee6469de53c667334dded1d22Structure();
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
    ssSTReportSAPStatus_Item.OptimizedAttributes = value[0];
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
ssSTReportSAPStatus_Item.Read( r, ref index);
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
public void ReadIM(RC_46bc538195fa6f6c2cd854e16266e629 r) {
this = r;
}


public static bool operator == (RC_46bc538195fa6f6c2cd854e16266e629 a, RC_46bc538195fa6f6c2cd854e16266e629 b) {
if (a.ssSTReportSAPStatus_Item != b.ssSTReportSAPStatus_Item) return false;
return true;
}

public static bool operator != (RC_46bc538195fa6f6c2cd854e16266e629 a, RC_46bc538195fa6f6c2cd854e16266e629 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_46bc538195fa6f6c2cd854e16266e629)) return false;
return (this == (RC_46bc538195fa6f6c2cd854e16266e629)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTReportSAPStatus_Item.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTReportSAPStatus_Item.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTReportSAPStatus_Item.InternalRecursiveSave();
}


public RC_46bc538195fa6f6c2cd854e16266e629 Duplicate() {
RC_46bc538195fa6f6c2cd854e16266e629 t;
t.ssSTReportSAPStatus_Item = (ST_fc6debbee6469de53c667334dded1d22Structure)this.ssSTReportSAPStatus_Item.Duplicate();
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
if (head == "reportsapstatus_item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ReportSAPStatus_Item")) variable.Value = ssSTReportSAPStatus_Item; else variable.Optimized = true;
variable.SetFieldName("reportsapstatus_item");
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
if (key == IdReportSAPStatus_Item) {
return ssSTReportSAPStatus_Item;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdReportSAPStatus_Item.Key.AsGuid) {
return ssSTReportSAPStatus_Item;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTReportSAPStatus_Item.FillFromOther((IRecord) other.AttributeGet(IdReportSAPStatus_Item));
}
} // RC_46bc538195fa6f6c2cd854e16266e629
/// <summary>
/// RecordList type <code>ReportSAPStatus_ItemRecordList</code> that represents a record list of
///  <code>ReportSAPStatus_Item</code>
/// </summary>
public partial class RL_91302ca9d24345d7f5935d3bb1ce5c97 : GenericRecordList<RC_46bc538195fa6f6c2cd854e16266e629>, IEnumerable, IEnumerator {

protected override RC_46bc538195fa6f6c2cd854e16266e629 GetElementDefaultValue() {
return new RC_46bc538195fa6f6c2cd854e16266e629();
}

public T[] ToArray<T>(Func<RC_46bc538195fa6f6c2cd854e16266e629, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_91302ca9d24345d7f5935d3bb1ce5c97 recordList, Func<RC_46bc538195fa6f6c2cd854e16266e629, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_91302ca9d24345d7f5935d3bb1ce5c97(RC_46bc538195fa6f6c2cd854e16266e629[] array) {
  RL_91302ca9d24345d7f5935d3bb1ce5c97 result = new RL_91302ca9d24345d7f5935d3bb1ce5c97();
result.InnerFromArray(array);
    return result;
}

public static RL_91302ca9d24345d7f5935d3bb1ce5c97 ToList<T>(T[] array, Func <T, RC_46bc538195fa6f6c2cd854e16266e629> converter) {
  RL_91302ca9d24345d7f5935d3bb1ce5c97 result = new RL_91302ca9d24345d7f5935d3bb1ce5c97();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_91302ca9d24345d7f5935d3bb1ce5c97 FromRestList<T>(RestList<T> restList, Func <T, RC_46bc538195fa6f6c2cd854e16266e629> converter) {
  RL_91302ca9d24345d7f5935d3bb1ce5c97 result = new RL_91302ca9d24345d7f5935d3bb1ce5c97();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_91302ca9d24345d7f5935d3bb1ce5c97() : base() {
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
protected override OSList<RC_46bc538195fa6f6c2cd854e16266e629> NewList() {
return new RL_91302ca9d24345d7f5935d3bb1ce5c97();
}


} // RL_91302ca9d24345d7f5935d3bb1ce5c97
}

