namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (teU3J2OkikKtNH5tLXXT3Q)
///  <code>RC_9d0f900078fdcea91c0916976b02ff7f</code> that represents <code>T_DAT_PROV_OutRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: T_DAT_PROV_OutRecord
public partial struct RC_9d0f900078fdcea91c0916976b02ff7f : ITypedRecord<RC_9d0f900078fdcea91c0916976b02ff7f> {
internal static readonly GlobalObjectKey IdT_DAT_PROV_Out = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AJAPnf14qc4cCRaXawL_fw");

public ST_4639a265770186863b3ecaeafd29fb96Structure ssSTT_DAT_PROV_Out;


public static implicit operator ST_4639a265770186863b3ecaeafd29fb96Structure( RC_9d0f900078fdcea91c0916976b02ff7f r) {
return r.ssSTT_DAT_PROV_Out;
}

public static implicit operator RC_9d0f900078fdcea91c0916976b02ff7f (ST_4639a265770186863b3ecaeafd29fb96Structure r) {
RC_9d0f900078fdcea91c0916976b02ff7f res = new RC_9d0f900078fdcea91c0916976b02ff7f ();
res.ssSTT_DAT_PROV_Out = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9d0f900078fdcea91c0916976b02ff7f() {
OptimizedAttributes = null;
ssSTT_DAT_PROV_Out = new ST_4639a265770186863b3ecaeafd29fb96Structure();
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
    ssSTT_DAT_PROV_Out.OptimizedAttributes = value[0];
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
ssSTT_DAT_PROV_Out.Read( r, ref index);
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
public void ReadIM(RC_9d0f900078fdcea91c0916976b02ff7f r) {
this = r;
}


public static bool operator == (RC_9d0f900078fdcea91c0916976b02ff7f a, RC_9d0f900078fdcea91c0916976b02ff7f b) {
if (a.ssSTT_DAT_PROV_Out != b.ssSTT_DAT_PROV_Out) return false;
return true;
}

public static bool operator != (RC_9d0f900078fdcea91c0916976b02ff7f a, RC_9d0f900078fdcea91c0916976b02ff7f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9d0f900078fdcea91c0916976b02ff7f)) return false;
return (this == (RC_9d0f900078fdcea91c0916976b02ff7f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTT_DAT_PROV_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTT_DAT_PROV_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTT_DAT_PROV_Out.InternalRecursiveSave();
}


public RC_9d0f900078fdcea91c0916976b02ff7f Duplicate() {
RC_9d0f900078fdcea91c0916976b02ff7f t;
t.ssSTT_DAT_PROV_Out = (ST_4639a265770186863b3ecaeafd29fb96Structure)this.ssSTT_DAT_PROV_Out.Duplicate();
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
if (head == "t_dat_prov_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_DAT_PROV_Out")) variable.Value = ssSTT_DAT_PROV_Out; else variable.Optimized = true;
variable.SetFieldName("t_dat_prov_out");
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
if (key == IdT_DAT_PROV_Out) {
return ssSTT_DAT_PROV_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdT_DAT_PROV_Out.Key.AsGuid) {
return ssSTT_DAT_PROV_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTT_DAT_PROV_Out.FillFromOther((IRecord) other.AttributeGet(IdT_DAT_PROV_Out));
}
} // RC_9d0f900078fdcea91c0916976b02ff7f
/// <summary>
/// RecordList type <code>T_DAT_PROV_OutRecordList</code> that represents a record list of
///  <code>T_DAT_PROV_Out</code>
/// </summary>
public partial class RL_0bf06634cff443ea320433f4cb61a466 : GenericRecordList<RC_9d0f900078fdcea91c0916976b02ff7f>, IEnumerable, IEnumerator {

protected override RC_9d0f900078fdcea91c0916976b02ff7f GetElementDefaultValue() {
return new RC_9d0f900078fdcea91c0916976b02ff7f();
}

public T[] ToArray<T>(Func<RC_9d0f900078fdcea91c0916976b02ff7f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0bf06634cff443ea320433f4cb61a466 recordList, Func<RC_9d0f900078fdcea91c0916976b02ff7f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0bf06634cff443ea320433f4cb61a466(RC_9d0f900078fdcea91c0916976b02ff7f[] array) {
  RL_0bf06634cff443ea320433f4cb61a466 result = new RL_0bf06634cff443ea320433f4cb61a466();
result.InnerFromArray(array);
    return result;
}

public static RL_0bf06634cff443ea320433f4cb61a466 ToList<T>(T[] array, Func <T, RC_9d0f900078fdcea91c0916976b02ff7f> converter) {
  RL_0bf06634cff443ea320433f4cb61a466 result = new RL_0bf06634cff443ea320433f4cb61a466();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0bf06634cff443ea320433f4cb61a466 FromRestList<T>(RestList<T> restList, Func <T, RC_9d0f900078fdcea91c0916976b02ff7f> converter) {
  RL_0bf06634cff443ea320433f4cb61a466 result = new RL_0bf06634cff443ea320433f4cb61a466();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0bf06634cff443ea320433f4cb61a466() : base() {
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
protected override OSList<RC_9d0f900078fdcea91c0916976b02ff7f> NewList() {
return new RL_0bf06634cff443ea320433f4cb61a466();
}


} // RL_0bf06634cff443ea320433f4cb61a466
}

