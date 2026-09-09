namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (DsGzRRLquk2zfI+sG3JSjw)
///  <code>RC_80a85ef874ec36a6401c319bb24497b9</code> that represents <code>ACCOUNT_DETAILRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ACCOUNT_DETAILRecord
public partial struct RC_80a85ef874ec36a6401c319bb24497b9 : ITypedRecord<RC_80a85ef874ec36a6401c319bb24497b9> {
internal static readonly GlobalObjectKey IdACCOUNT_DETAIL = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+F6ogOx0pjZAHDGbskSXuQ");

public ST_d2beaf811f074c88054765b10d929011Structure ssSTACCOUNT_DETAIL;


public static implicit operator ST_d2beaf811f074c88054765b10d929011Structure( RC_80a85ef874ec36a6401c319bb24497b9 r) {
return r.ssSTACCOUNT_DETAIL;
}

public static implicit operator RC_80a85ef874ec36a6401c319bb24497b9 (ST_d2beaf811f074c88054765b10d929011Structure r) {
RC_80a85ef874ec36a6401c319bb24497b9 res = new RC_80a85ef874ec36a6401c319bb24497b9 ();
res.ssSTACCOUNT_DETAIL = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_80a85ef874ec36a6401c319bb24497b9() {
OptimizedAttributes = null;
ssSTACCOUNT_DETAIL = new ST_d2beaf811f074c88054765b10d929011Structure();
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
    ssSTACCOUNT_DETAIL.OptimizedAttributes = value[0];
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
ssSTACCOUNT_DETAIL.Read( r, ref index);
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
public void ReadIM(RC_80a85ef874ec36a6401c319bb24497b9 r) {
this = r;
}


public static bool operator == (RC_80a85ef874ec36a6401c319bb24497b9 a, RC_80a85ef874ec36a6401c319bb24497b9 b) {
if (a.ssSTACCOUNT_DETAIL != b.ssSTACCOUNT_DETAIL) return false;
return true;
}

public static bool operator != (RC_80a85ef874ec36a6401c319bb24497b9 a, RC_80a85ef874ec36a6401c319bb24497b9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_80a85ef874ec36a6401c319bb24497b9)) return false;
return (this == (RC_80a85ef874ec36a6401c319bb24497b9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTACCOUNT_DETAIL.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTACCOUNT_DETAIL.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTACCOUNT_DETAIL.InternalRecursiveSave();
}


public RC_80a85ef874ec36a6401c319bb24497b9 Duplicate() {
RC_80a85ef874ec36a6401c319bb24497b9 t;
t.ssSTACCOUNT_DETAIL = (ST_d2beaf811f074c88054765b10d929011Structure)this.ssSTACCOUNT_DETAIL.Duplicate();
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
if (head == "account_detail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ACCOUNT_DETAIL")) variable.Value = ssSTACCOUNT_DETAIL; else variable.Optimized = true;
variable.SetFieldName("account_detail");
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
if (key == IdACCOUNT_DETAIL) {
return ssSTACCOUNT_DETAIL;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdACCOUNT_DETAIL.Key.AsGuid) {
return ssSTACCOUNT_DETAIL;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTACCOUNT_DETAIL.FillFromOther((IRecord) other.AttributeGet(IdACCOUNT_DETAIL));
}
} // RC_80a85ef874ec36a6401c319bb24497b9
/// <summary>
/// RecordList type <code>ACCOUNT_DETAILRecordList</code> that represents a record list of
///  <code>ACCOUNT_DETAIL</code>
/// </summary>
public partial class RL_ea224c9127206d2db43cc511ba1821f7 : GenericRecordList<RC_80a85ef874ec36a6401c319bb24497b9>, IEnumerable, IEnumerator {

protected override RC_80a85ef874ec36a6401c319bb24497b9 GetElementDefaultValue() {
return new RC_80a85ef874ec36a6401c319bb24497b9();
}

public T[] ToArray<T>(Func<RC_80a85ef874ec36a6401c319bb24497b9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ea224c9127206d2db43cc511ba1821f7 recordList, Func<RC_80a85ef874ec36a6401c319bb24497b9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ea224c9127206d2db43cc511ba1821f7(RC_80a85ef874ec36a6401c319bb24497b9[] array) {
  RL_ea224c9127206d2db43cc511ba1821f7 result = new RL_ea224c9127206d2db43cc511ba1821f7();
result.InnerFromArray(array);
    return result;
}

public static RL_ea224c9127206d2db43cc511ba1821f7 ToList<T>(T[] array, Func <T, RC_80a85ef874ec36a6401c319bb24497b9> converter) {
  RL_ea224c9127206d2db43cc511ba1821f7 result = new RL_ea224c9127206d2db43cc511ba1821f7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ea224c9127206d2db43cc511ba1821f7 FromRestList<T>(RestList<T> restList, Func <T, RC_80a85ef874ec36a6401c319bb24497b9> converter) {
  RL_ea224c9127206d2db43cc511ba1821f7 result = new RL_ea224c9127206d2db43cc511ba1821f7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ea224c9127206d2db43cc511ba1821f7() : base() {
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
protected override OSList<RC_80a85ef874ec36a6401c319bb24497b9> NewList() {
return new RL_ea224c9127206d2db43cc511ba1821f7();
}


} // RL_ea224c9127206d2db43cc511ba1821f7
}

