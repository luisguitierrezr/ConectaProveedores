namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (oPX7WW36WUG4ffBhMP8pAw)
///  <code>RC_29185b1ce9f3c243b59d0d98b65d335e</code> that represents <code>OrderItemLineRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderItemLineRecord
public partial struct RC_29185b1ce9f3c243b59d0d98b65d335e : ITypedRecord<RC_29185b1ce9f3c243b59d0d98b65d335e> {
internal static readonly GlobalObjectKey IdOrderItemLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HFsYKfPpQ8K1nQ2Ytl0zXg");

public ST_602b1becf0e261abf8529c8c55991799Structure ssSTOrderItemLine;


public static implicit operator ST_602b1becf0e261abf8529c8c55991799Structure( RC_29185b1ce9f3c243b59d0d98b65d335e r) {
return r.ssSTOrderItemLine;
}

public static implicit operator RC_29185b1ce9f3c243b59d0d98b65d335e (ST_602b1becf0e261abf8529c8c55991799Structure r) {
RC_29185b1ce9f3c243b59d0d98b65d335e res = new RC_29185b1ce9f3c243b59d0d98b65d335e ();
res.ssSTOrderItemLine = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_29185b1ce9f3c243b59d0d98b65d335e() {
OptimizedAttributes = null;
ssSTOrderItemLine = new ST_602b1becf0e261abf8529c8c55991799Structure();
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
    ssSTOrderItemLine.OptimizedAttributes = value[0];
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
ssSTOrderItemLine.Read( r, ref index);
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
public void ReadIM(RC_29185b1ce9f3c243b59d0d98b65d335e r) {
this = r;
}


public static bool operator == (RC_29185b1ce9f3c243b59d0d98b65d335e a, RC_29185b1ce9f3c243b59d0d98b65d335e b) {
if (a.ssSTOrderItemLine != b.ssSTOrderItemLine) return false;
return true;
}

public static bool operator != (RC_29185b1ce9f3c243b59d0d98b65d335e a, RC_29185b1ce9f3c243b59d0d98b65d335e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_29185b1ce9f3c243b59d0d98b65d335e)) return false;
return (this == (RC_29185b1ce9f3c243b59d0d98b65d335e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrderItemLine.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrderItemLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrderItemLine.InternalRecursiveSave();
}


public RC_29185b1ce9f3c243b59d0d98b65d335e Duplicate() {
RC_29185b1ce9f3c243b59d0d98b65d335e t;
t.ssSTOrderItemLine = (ST_602b1becf0e261abf8529c8c55991799Structure)this.ssSTOrderItemLine.Duplicate();
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
if (head == "orderitemline") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderItemLine")) variable.Value = ssSTOrderItemLine; else variable.Optimized = true;
variable.SetFieldName("orderitemline");
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
if (key == IdOrderItemLine) {
return ssSTOrderItemLine;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderItemLine.Key.AsGuid) {
return ssSTOrderItemLine;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrderItemLine.FillFromOther((IRecord) other.AttributeGet(IdOrderItemLine));
}
} // RC_29185b1ce9f3c243b59d0d98b65d335e
/// <summary>
/// RecordList type <code>OrderItemLineRecordList</code> that represents a record list of
///  <code>OrderItemLine</code>
/// </summary>
public partial class RL_9899f0787d4eeff985f96137b720a67b : GenericRecordList<RC_29185b1ce9f3c243b59d0d98b65d335e>, IEnumerable, IEnumerator {

protected override RC_29185b1ce9f3c243b59d0d98b65d335e GetElementDefaultValue() {
return new RC_29185b1ce9f3c243b59d0d98b65d335e();
}

public T[] ToArray<T>(Func<RC_29185b1ce9f3c243b59d0d98b65d335e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9899f0787d4eeff985f96137b720a67b recordList, Func<RC_29185b1ce9f3c243b59d0d98b65d335e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9899f0787d4eeff985f96137b720a67b(RC_29185b1ce9f3c243b59d0d98b65d335e[] array) {
  RL_9899f0787d4eeff985f96137b720a67b result = new RL_9899f0787d4eeff985f96137b720a67b();
result.InnerFromArray(array);
    return result;
}

public static RL_9899f0787d4eeff985f96137b720a67b ToList<T>(T[] array, Func <T, RC_29185b1ce9f3c243b59d0d98b65d335e> converter) {
  RL_9899f0787d4eeff985f96137b720a67b result = new RL_9899f0787d4eeff985f96137b720a67b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9899f0787d4eeff985f96137b720a67b FromRestList<T>(RestList<T> restList, Func <T, RC_29185b1ce9f3c243b59d0d98b65d335e> converter) {
  RL_9899f0787d4eeff985f96137b720a67b result = new RL_9899f0787d4eeff985f96137b720a67b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9899f0787d4eeff985f96137b720a67b() : base() {
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
protected override OSList<RC_29185b1ce9f3c243b59d0d98b65d335e> NewList() {
return new RL_9899f0787d4eeff985f96137b720a67b();
}


} // RL_9899f0787d4eeff985f96137b720a67b
}

