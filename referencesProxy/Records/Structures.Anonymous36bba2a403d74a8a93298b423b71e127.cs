namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (pKK7NtcDikqTKYtCO3HhJw)
///  <code>RC_94d82433e65dbd6bd2e4554a9c8fd005</code> that represents <code>TI_WXD_InRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_WXD_InRecord
public partial struct RC_94d82433e65dbd6bd2e4554a9c8fd005 : ITypedRecord<RC_94d82433e65dbd6bd2e4554a9c8fd005> {
internal static readonly GlobalObjectKey IdTI_WXD_In = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MyTYlF3ma73S5FVKnI_QBQ");

public ST_a8dbb50321f7e9ee99b69f05907922f9Structure ssSTTI_WXD_In;


public static implicit operator ST_a8dbb50321f7e9ee99b69f05907922f9Structure( RC_94d82433e65dbd6bd2e4554a9c8fd005 r) {
return r.ssSTTI_WXD_In;
}

public static implicit operator RC_94d82433e65dbd6bd2e4554a9c8fd005 (ST_a8dbb50321f7e9ee99b69f05907922f9Structure r) {
RC_94d82433e65dbd6bd2e4554a9c8fd005 res = new RC_94d82433e65dbd6bd2e4554a9c8fd005 ();
res.ssSTTI_WXD_In = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_94d82433e65dbd6bd2e4554a9c8fd005() {
OptimizedAttributes = null;
ssSTTI_WXD_In = new ST_a8dbb50321f7e9ee99b69f05907922f9Structure();
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
    ssSTTI_WXD_In.OptimizedAttributes = value[0];
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
ssSTTI_WXD_In.Read( r, ref index);
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
public void ReadIM(RC_94d82433e65dbd6bd2e4554a9c8fd005 r) {
this = r;
}


public static bool operator == (RC_94d82433e65dbd6bd2e4554a9c8fd005 a, RC_94d82433e65dbd6bd2e4554a9c8fd005 b) {
if (a.ssSTTI_WXD_In != b.ssSTTI_WXD_In) return false;
return true;
}

public static bool operator != (RC_94d82433e65dbd6bd2e4554a9c8fd005 a, RC_94d82433e65dbd6bd2e4554a9c8fd005 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_94d82433e65dbd6bd2e4554a9c8fd005)) return false;
return (this == (RC_94d82433e65dbd6bd2e4554a9c8fd005)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_WXD_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_WXD_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_WXD_In.InternalRecursiveSave();
}


public RC_94d82433e65dbd6bd2e4554a9c8fd005 Duplicate() {
RC_94d82433e65dbd6bd2e4554a9c8fd005 t;
t.ssSTTI_WXD_In = (ST_a8dbb50321f7e9ee99b69f05907922f9Structure)this.ssSTTI_WXD_In.Duplicate();
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
if (head == "ti_wxd_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_WXD_In")) variable.Value = ssSTTI_WXD_In; else variable.Optimized = true;
variable.SetFieldName("ti_wxd_in");
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
if (key == IdTI_WXD_In) {
return ssSTTI_WXD_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_WXD_In.Key.AsGuid) {
return ssSTTI_WXD_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_WXD_In.FillFromOther((IRecord) other.AttributeGet(IdTI_WXD_In));
}
} // RC_94d82433e65dbd6bd2e4554a9c8fd005
/// <summary>
/// RecordList type <code>TI_WXD_InRecordList</code> that represents a record list of
///  <code>TI_WXD_In</code>
/// </summary>
public partial class RL_6be5dc70f68dca537454587d02cea8d2 : GenericRecordList<RC_94d82433e65dbd6bd2e4554a9c8fd005>, IEnumerable, IEnumerator {

protected override RC_94d82433e65dbd6bd2e4554a9c8fd005 GetElementDefaultValue() {
return new RC_94d82433e65dbd6bd2e4554a9c8fd005();
}

public T[] ToArray<T>(Func<RC_94d82433e65dbd6bd2e4554a9c8fd005, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6be5dc70f68dca537454587d02cea8d2 recordList, Func<RC_94d82433e65dbd6bd2e4554a9c8fd005, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6be5dc70f68dca537454587d02cea8d2(RC_94d82433e65dbd6bd2e4554a9c8fd005[] array) {
  RL_6be5dc70f68dca537454587d02cea8d2 result = new RL_6be5dc70f68dca537454587d02cea8d2();
result.InnerFromArray(array);
    return result;
}

public static RL_6be5dc70f68dca537454587d02cea8d2 ToList<T>(T[] array, Func <T, RC_94d82433e65dbd6bd2e4554a9c8fd005> converter) {
  RL_6be5dc70f68dca537454587d02cea8d2 result = new RL_6be5dc70f68dca537454587d02cea8d2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6be5dc70f68dca537454587d02cea8d2 FromRestList<T>(RestList<T> restList, Func <T, RC_94d82433e65dbd6bd2e4554a9c8fd005> converter) {
  RL_6be5dc70f68dca537454587d02cea8d2 result = new RL_6be5dc70f68dca537454587d02cea8d2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6be5dc70f68dca537454587d02cea8d2() : base() {
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
protected override OSList<RC_94d82433e65dbd6bd2e4554a9c8fd005> NewList() {
return new RL_6be5dc70f68dca537454587d02cea8d2();
}


} // RL_6be5dc70f68dca537454587d02cea8d2
}

