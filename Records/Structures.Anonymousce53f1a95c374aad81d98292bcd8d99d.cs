namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (qfFTzjdcrUqB2YKSvNjZnQ)
///  <code>RC_dc9a6819825fee88eba01192ae9b1890</code> that represent
/// s <code>OrderAccConceptsRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderAccConceptsRecord
public partial struct RC_dc9a6819825fee88eba01192ae9b1890 : ITypedRecord<RC_dc9a6819825fee88eba01192ae9b1890> {
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;


public static implicit operator EN_3e07a23619060cc7dc5624548803f5fdEntityRecord( RC_dc9a6819825fee88eba01192ae9b1890 r) {
return r.ssENOrderAccConcepts;
}

public static implicit operator RC_dc9a6819825fee88eba01192ae9b1890 (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord r) {
RC_dc9a6819825fee88eba01192ae9b1890 res = new RC_dc9a6819825fee88eba01192ae9b1890 ();
res.ssENOrderAccConcepts = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderAccConcepts.ChangedAttributes = value;
}
get {
    return ssENOrderAccConcepts.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_dc9a6819825fee88eba01192ae9b1890() {
OptimizedAttributes = null;
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(14,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderAccConcepts.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderAccConcepts.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderAccConcepts.Read( r, ref index);
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
public void ReadIM(RC_dc9a6819825fee88eba01192ae9b1890 r) {
this = r;
}


public static bool operator == (RC_dc9a6819825fee88eba01192ae9b1890 a, RC_dc9a6819825fee88eba01192ae9b1890 b) {
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
return true;
}

public static bool operator != (RC_dc9a6819825fee88eba01192ae9b1890 a, RC_dc9a6819825fee88eba01192ae9b1890 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dc9a6819825fee88eba01192ae9b1890)) return false;
return (this == (RC_dc9a6819825fee88eba01192ae9b1890)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderAccConcepts.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderAccConcepts.InternalRecursiveSave();
}


public RC_dc9a6819825fee88eba01192ae9b1890 Duplicate() {
RC_dc9a6819825fee88eba01192ae9b1890 t;
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
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
if (head == "orderaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConcepts")) variable.Value = ssENOrderAccConcepts; else variable.Optimized = true;
variable.SetFieldName("orderaccconcepts");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderAccConcepts.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderAccConcepts.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderAccConcepts) {
return ssENOrderAccConcepts;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderAccConcepts.Key.AsGuid) {
return ssENOrderAccConcepts;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdOrderAccConcepts));
}
} // RC_dc9a6819825fee88eba01192ae9b1890
/// <summary>
/// RecordList type <code>OrderAccConceptsRecordList</code> that represents a record list of
///  <code>OrderAccConcepts</code>
/// </summary>
public partial class RL_f805dfae1f4ccde9f7b0028b80707abe : GenericRecordList<RC_dc9a6819825fee88eba01192ae9b1890>, IEnumerable, IEnumerator {

protected override RC_dc9a6819825fee88eba01192ae9b1890 GetElementDefaultValue() {
return new RC_dc9a6819825fee88eba01192ae9b1890();
}

public T[] ToArray<T>(Func<RC_dc9a6819825fee88eba01192ae9b1890, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f805dfae1f4ccde9f7b0028b80707abe recordList, Func<RC_dc9a6819825fee88eba01192ae9b1890, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f805dfae1f4ccde9f7b0028b80707abe(RC_dc9a6819825fee88eba01192ae9b1890[] array) {
  RL_f805dfae1f4ccde9f7b0028b80707abe result = new RL_f805dfae1f4ccde9f7b0028b80707abe();
result.InnerFromArray(array);
    return result;
}

public static RL_f805dfae1f4ccde9f7b0028b80707abe ToList<T>(T[] array, Func <T, RC_dc9a6819825fee88eba01192ae9b1890> converter) {
  RL_f805dfae1f4ccde9f7b0028b80707abe result = new RL_f805dfae1f4ccde9f7b0028b80707abe();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f805dfae1f4ccde9f7b0028b80707abe FromRestList<T>(RestList<T> restList, Func <T, RC_dc9a6819825fee88eba01192ae9b1890> converter) {
  RL_f805dfae1f4ccde9f7b0028b80707abe result = new RL_f805dfae1f4ccde9f7b0028b80707abe();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f805dfae1f4ccde9f7b0028b80707abe() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(14,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_dc9a6819825fee88eba01192ae9b1890> NewList() {
return new RL_f805dfae1f4ccde9f7b0028b80707abe();
}


} // RL_f805dfae1f4ccde9f7b0028b80707abe
}

