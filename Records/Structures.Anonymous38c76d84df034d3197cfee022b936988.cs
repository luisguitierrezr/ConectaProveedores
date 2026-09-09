namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (hG3HOAPfMU2Xz+4CK5NpiA)
///  <code>RC_3b7b8fb2298150c3f700b016b10ccf3a</code> that represent
/// s <code>OrdersToConsultReportRecord</code> <p>Description: </p>
/// </summary>
// Name: OrdersToConsultReportRecord
public partial struct RC_3b7b8fb2298150c3f700b016b10ccf3a : ITypedRecord<RC_3b7b8fb2298150c3f700b016b10ccf3a> {
internal static readonly GlobalObjectKey IdOrdersToConsultReport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*so97O4Epw1D3ALAWsQzPOg");

public ST_dd2f99ddb27fc3276d14217f47cde22fStructure ssSTOrdersToConsultReport;


public static implicit operator ST_dd2f99ddb27fc3276d14217f47cde22fStructure( RC_3b7b8fb2298150c3f700b016b10ccf3a r) {
return r.ssSTOrdersToConsultReport;
}

public static implicit operator RC_3b7b8fb2298150c3f700b016b10ccf3a (ST_dd2f99ddb27fc3276d14217f47cde22fStructure r) {
RC_3b7b8fb2298150c3f700b016b10ccf3a res = new RC_3b7b8fb2298150c3f700b016b10ccf3a ();
res.ssSTOrdersToConsultReport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3b7b8fb2298150c3f700b016b10ccf3a() {
OptimizedAttributes = null;
ssSTOrdersToConsultReport = new ST_dd2f99ddb27fc3276d14217f47cde22fStructure();
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
    ssSTOrdersToConsultReport.OptimizedAttributes = value[0];
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
ssSTOrdersToConsultReport.Read( r, ref index);
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
public void ReadIM(RC_3b7b8fb2298150c3f700b016b10ccf3a r) {
this = r;
}


public static bool operator == (RC_3b7b8fb2298150c3f700b016b10ccf3a a, RC_3b7b8fb2298150c3f700b016b10ccf3a b) {
if (a.ssSTOrdersToConsultReport != b.ssSTOrdersToConsultReport) return false;
return true;
}

public static bool operator != (RC_3b7b8fb2298150c3f700b016b10ccf3a a, RC_3b7b8fb2298150c3f700b016b10ccf3a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3b7b8fb2298150c3f700b016b10ccf3a)) return false;
return (this == (RC_3b7b8fb2298150c3f700b016b10ccf3a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrdersToConsultReport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrdersToConsultReport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrdersToConsultReport.InternalRecursiveSave();
}


public RC_3b7b8fb2298150c3f700b016b10ccf3a Duplicate() {
RC_3b7b8fb2298150c3f700b016b10ccf3a t;
t.ssSTOrdersToConsultReport = (ST_dd2f99ddb27fc3276d14217f47cde22fStructure)this.ssSTOrdersToConsultReport.Duplicate();
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
if (head == "orderstoconsultreport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdersToConsultReport")) variable.Value = ssSTOrdersToConsultReport; else variable.Optimized = true;
variable.SetFieldName("orderstoconsultreport");
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
if (key == IdOrdersToConsultReport) {
return ssSTOrdersToConsultReport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrdersToConsultReport.Key.AsGuid) {
return ssSTOrdersToConsultReport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrdersToConsultReport.FillFromOther((IRecord) other.AttributeGet(IdOrdersToConsultReport));
}
} // RC_3b7b8fb2298150c3f700b016b10ccf3a
/// <summary>
/// RecordList type <code>OrdersToConsultReportRecordList</code> that represents a record list of
///  <code>OrdersToConsultReport</code>
/// </summary>
public partial class RL_88e82899ce1ee14870c20281d32beb8f : GenericRecordList<RC_3b7b8fb2298150c3f700b016b10ccf3a>, IEnumerable, IEnumerator {

protected override RC_3b7b8fb2298150c3f700b016b10ccf3a GetElementDefaultValue() {
return new RC_3b7b8fb2298150c3f700b016b10ccf3a();
}

public T[] ToArray<T>(Func<RC_3b7b8fb2298150c3f700b016b10ccf3a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_88e82899ce1ee14870c20281d32beb8f recordList, Func<RC_3b7b8fb2298150c3f700b016b10ccf3a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_88e82899ce1ee14870c20281d32beb8f(RC_3b7b8fb2298150c3f700b016b10ccf3a[] array) {
  RL_88e82899ce1ee14870c20281d32beb8f result = new RL_88e82899ce1ee14870c20281d32beb8f();
result.InnerFromArray(array);
    return result;
}

public static RL_88e82899ce1ee14870c20281d32beb8f ToList<T>(T[] array, Func <T, RC_3b7b8fb2298150c3f700b016b10ccf3a> converter) {
  RL_88e82899ce1ee14870c20281d32beb8f result = new RL_88e82899ce1ee14870c20281d32beb8f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_88e82899ce1ee14870c20281d32beb8f FromRestList<T>(RestList<T> restList, Func <T, RC_3b7b8fb2298150c3f700b016b10ccf3a> converter) {
  RL_88e82899ce1ee14870c20281d32beb8f result = new RL_88e82899ce1ee14870c20281d32beb8f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_88e82899ce1ee14870c20281d32beb8f() : base() {
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
protected override OSList<RC_3b7b8fb2298150c3f700b016b10ccf3a> NewList() {
return new RL_88e82899ce1ee14870c20281d32beb8f();
}


} // RL_88e82899ce1ee14870c20281d32beb8f
}

