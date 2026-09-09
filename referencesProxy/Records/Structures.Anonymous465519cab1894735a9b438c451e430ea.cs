namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (yhlVRomxNUeptDjEUeQw6g)
///  <code>RC_c06f8a0170c6518f22bc1e9645ee082e</code> that represents <code>ValueItemRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ValueItemRecord
public partial struct RC_c06f8a0170c6518f22bc1e9645ee082e : ITypedRecord<RC_c06f8a0170c6518f22bc1e9645ee082e> {
internal static readonly GlobalObjectKey IdValueItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AYpvwMZwj1EivB6WRe4ILg");

public ST_d32097d2629a99529d77b865dae9fb0cStructure ssSTValueItem;


public static implicit operator ST_d32097d2629a99529d77b865dae9fb0cStructure( RC_c06f8a0170c6518f22bc1e9645ee082e r) {
return r.ssSTValueItem;
}

public static implicit operator RC_c06f8a0170c6518f22bc1e9645ee082e (ST_d32097d2629a99529d77b865dae9fb0cStructure r) {
RC_c06f8a0170c6518f22bc1e9645ee082e res = new RC_c06f8a0170c6518f22bc1e9645ee082e ();
res.ssSTValueItem = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c06f8a0170c6518f22bc1e9645ee082e() {
OptimizedAttributes = null;
ssSTValueItem = new ST_d32097d2629a99529d77b865dae9fb0cStructure();
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
    ssSTValueItem.OptimizedAttributes = value[0];
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
ssSTValueItem.Read( r, ref index);
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
public void ReadIM(RC_c06f8a0170c6518f22bc1e9645ee082e r) {
this = r;
}


public static bool operator == (RC_c06f8a0170c6518f22bc1e9645ee082e a, RC_c06f8a0170c6518f22bc1e9645ee082e b) {
if (a.ssSTValueItem != b.ssSTValueItem) return false;
return true;
}

public static bool operator != (RC_c06f8a0170c6518f22bc1e9645ee082e a, RC_c06f8a0170c6518f22bc1e9645ee082e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c06f8a0170c6518f22bc1e9645ee082e)) return false;
return (this == (RC_c06f8a0170c6518f22bc1e9645ee082e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTValueItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTValueItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTValueItem.InternalRecursiveSave();
}


public RC_c06f8a0170c6518f22bc1e9645ee082e Duplicate() {
RC_c06f8a0170c6518f22bc1e9645ee082e t;
t.ssSTValueItem = (ST_d32097d2629a99529d77b865dae9fb0cStructure)this.ssSTValueItem.Duplicate();
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
if (head == "valueitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValueItem")) variable.Value = ssSTValueItem; else variable.Optimized = true;
variable.SetFieldName("valueitem");
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
if (key == IdValueItem) {
return ssSTValueItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValueItem.Key.AsGuid) {
return ssSTValueItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTValueItem.FillFromOther((IRecord) other.AttributeGet(IdValueItem));
}
} // RC_c06f8a0170c6518f22bc1e9645ee082e
/// <summary>
/// RecordList type <code>ValueItemRecordList</code> that represents a record list of
///  <code>ValueItem</code>
/// </summary>
public partial class RL_6881f5a541bcee95d797e1472e825ca2 : GenericRecordList<RC_c06f8a0170c6518f22bc1e9645ee082e>, IEnumerable, IEnumerator {

protected override RC_c06f8a0170c6518f22bc1e9645ee082e GetElementDefaultValue() {
return new RC_c06f8a0170c6518f22bc1e9645ee082e();
}

public T[] ToArray<T>(Func<RC_c06f8a0170c6518f22bc1e9645ee082e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6881f5a541bcee95d797e1472e825ca2 recordList, Func<RC_c06f8a0170c6518f22bc1e9645ee082e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6881f5a541bcee95d797e1472e825ca2(RC_c06f8a0170c6518f22bc1e9645ee082e[] array) {
  RL_6881f5a541bcee95d797e1472e825ca2 result = new RL_6881f5a541bcee95d797e1472e825ca2();
result.InnerFromArray(array);
    return result;
}

public static RL_6881f5a541bcee95d797e1472e825ca2 ToList<T>(T[] array, Func <T, RC_c06f8a0170c6518f22bc1e9645ee082e> converter) {
  RL_6881f5a541bcee95d797e1472e825ca2 result = new RL_6881f5a541bcee95d797e1472e825ca2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6881f5a541bcee95d797e1472e825ca2 FromRestList<T>(RestList<T> restList, Func <T, RC_c06f8a0170c6518f22bc1e9645ee082e> converter) {
  RL_6881f5a541bcee95d797e1472e825ca2 result = new RL_6881f5a541bcee95d797e1472e825ca2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6881f5a541bcee95d797e1472e825ca2() : base() {
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
protected override OSList<RC_c06f8a0170c6518f22bc1e9645ee082e> NewList() {
return new RL_6881f5a541bcee95d797e1472e825ca2();
}


} // RL_6881f5a541bcee95d797e1472e825ca2
}

