namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (SNYg2In5XkKG7342cjB4VA)
///  <code>RC_4e0e1f8a1546c166944674b06b11f045</code> that represents <code>PI_ITEM_EM4Record</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_EM4Record
public partial struct RC_4e0e1f8a1546c166944674b06b11f045 : ITypedRecord<RC_4e0e1f8a1546c166944674b06b11f045> {
internal static readonly GlobalObjectKey IdPI_ITEM_EM4 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ih8OTkYVZsGURnSwaxHwRQ");

public ST_5f3e5a981bd9e9a45ed03e989538932dStructure ssSTPI_ITEM_EM4;


public static implicit operator ST_5f3e5a981bd9e9a45ed03e989538932dStructure( RC_4e0e1f8a1546c166944674b06b11f045 r) {
return r.ssSTPI_ITEM_EM4;
}

public static implicit operator RC_4e0e1f8a1546c166944674b06b11f045 (ST_5f3e5a981bd9e9a45ed03e989538932dStructure r) {
RC_4e0e1f8a1546c166944674b06b11f045 res = new RC_4e0e1f8a1546c166944674b06b11f045 ();
res.ssSTPI_ITEM_EM4 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4e0e1f8a1546c166944674b06b11f045() {
OptimizedAttributes = null;
ssSTPI_ITEM_EM4 = new ST_5f3e5a981bd9e9a45ed03e989538932dStructure();
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
    ssSTPI_ITEM_EM4.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_EM4.Read( r, ref index);
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
public void ReadIM(RC_4e0e1f8a1546c166944674b06b11f045 r) {
this = r;
}


public static bool operator == (RC_4e0e1f8a1546c166944674b06b11f045 a, RC_4e0e1f8a1546c166944674b06b11f045 b) {
if (a.ssSTPI_ITEM_EM4 != b.ssSTPI_ITEM_EM4) return false;
return true;
}

public static bool operator != (RC_4e0e1f8a1546c166944674b06b11f045 a, RC_4e0e1f8a1546c166944674b06b11f045 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4e0e1f8a1546c166944674b06b11f045)) return false;
return (this == (RC_4e0e1f8a1546c166944674b06b11f045)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_EM4.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_EM4.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_EM4.InternalRecursiveSave();
}


public RC_4e0e1f8a1546c166944674b06b11f045 Duplicate() {
RC_4e0e1f8a1546c166944674b06b11f045 t;
t.ssSTPI_ITEM_EM4 = (ST_5f3e5a981bd9e9a45ed03e989538932dStructure)this.ssSTPI_ITEM_EM4.Duplicate();
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
if (head == "pi_item_em4") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM4")) variable.Value = ssSTPI_ITEM_EM4; else variable.Optimized = true;
variable.SetFieldName("pi_item_em4");
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
if (key == IdPI_ITEM_EM4) {
return ssSTPI_ITEM_EM4;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_EM4.Key.AsGuid) {
return ssSTPI_ITEM_EM4;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_EM4.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_EM4));
}
} // RC_4e0e1f8a1546c166944674b06b11f045
/// <summary>
/// RecordList type <code>PI_ITEM_EM4RecordList</code> that represents a record list of
///  <code>PI_ITEM_EM4</code>
/// </summary>
public partial class RL_262c02e0e5df2961c0f2f4fc4883fb95 : GenericRecordList<RC_4e0e1f8a1546c166944674b06b11f045>, IEnumerable, IEnumerator {

protected override RC_4e0e1f8a1546c166944674b06b11f045 GetElementDefaultValue() {
return new RC_4e0e1f8a1546c166944674b06b11f045();
}

public T[] ToArray<T>(Func<RC_4e0e1f8a1546c166944674b06b11f045, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_262c02e0e5df2961c0f2f4fc4883fb95 recordList, Func<RC_4e0e1f8a1546c166944674b06b11f045, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_262c02e0e5df2961c0f2f4fc4883fb95(RC_4e0e1f8a1546c166944674b06b11f045[] array) {
  RL_262c02e0e5df2961c0f2f4fc4883fb95 result = new RL_262c02e0e5df2961c0f2f4fc4883fb95();
result.InnerFromArray(array);
    return result;
}

public static RL_262c02e0e5df2961c0f2f4fc4883fb95 ToList<T>(T[] array, Func <T, RC_4e0e1f8a1546c166944674b06b11f045> converter) {
  RL_262c02e0e5df2961c0f2f4fc4883fb95 result = new RL_262c02e0e5df2961c0f2f4fc4883fb95();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_262c02e0e5df2961c0f2f4fc4883fb95 FromRestList<T>(RestList<T> restList, Func <T, RC_4e0e1f8a1546c166944674b06b11f045> converter) {
  RL_262c02e0e5df2961c0f2f4fc4883fb95 result = new RL_262c02e0e5df2961c0f2f4fc4883fb95();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_262c02e0e5df2961c0f2f4fc4883fb95() : base() {
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
protected override OSList<RC_4e0e1f8a1546c166944674b06b11f045> NewList() {
return new RL_262c02e0e5df2961c0f2f4fc4883fb95();
}


} // RL_262c02e0e5df2961c0f2f4fc4883fb95
}

