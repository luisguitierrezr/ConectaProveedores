namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (J7veXGW3cEyyMSX0GnjwZg)
///  <code>RC_35113aa55a750ad2c238c201c4253736</code> that represents <code>OrderRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderRecord
public partial struct RC_35113aa55a750ad2c238c201c4253736 : ITypedRecord<RC_35113aa55a750ad2c238c201c4253736> {
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pToRNXVa0grCOMIBxCU3Ng");

public ST_1a18ac43e89b6e5649de540bf9caa846Structure ssSTOrder;


public static implicit operator ST_1a18ac43e89b6e5649de540bf9caa846Structure( RC_35113aa55a750ad2c238c201c4253736 r) {
return r.ssSTOrder;
}

public static implicit operator RC_35113aa55a750ad2c238c201c4253736 (ST_1a18ac43e89b6e5649de540bf9caa846Structure r) {
RC_35113aa55a750ad2c238c201c4253736 res = new RC_35113aa55a750ad2c238c201c4253736 ();
res.ssSTOrder = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_35113aa55a750ad2c238c201c4253736() {
OptimizedAttributes = null;
ssSTOrder = new ST_1a18ac43e89b6e5649de540bf9caa846Structure();
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
    ssSTOrder.OptimizedAttributes = value[0];
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
ssSTOrder.Read( r, ref index);
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
public void ReadIM(RC_35113aa55a750ad2c238c201c4253736 r) {
this = r;
}


public static bool operator == (RC_35113aa55a750ad2c238c201c4253736 a, RC_35113aa55a750ad2c238c201c4253736 b) {
if (a.ssSTOrder != b.ssSTOrder) return false;
return true;
}

public static bool operator != (RC_35113aa55a750ad2c238c201c4253736 a, RC_35113aa55a750ad2c238c201c4253736 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_35113aa55a750ad2c238c201c4253736)) return false;
return (this == (RC_35113aa55a750ad2c238c201c4253736)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrder.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrder.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrder.InternalRecursiveSave();
}


public RC_35113aa55a750ad2c238c201c4253736 Duplicate() {
RC_35113aa55a750ad2c238c201c4253736 t;
t.ssSTOrder = (ST_1a18ac43e89b6e5649de540bf9caa846Structure)this.ssSTOrder.Duplicate();
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
if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssSTOrder; else variable.Optimized = true;
variable.SetFieldName("order");
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
if (key == IdOrder) {
return ssSTOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrder.Key.AsGuid) {
return ssSTOrder;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrder.FillFromOther((IRecord) other.AttributeGet(IdOrder));
}
} // RC_35113aa55a750ad2c238c201c4253736
/// <summary>
/// RecordList type <code>OrderRecordList</code> that represents a record list of <code>Order</code>
/// </summary>
public partial class RL_45a2a678e0c897a57aacb30f6fec9213 : GenericRecordList<RC_35113aa55a750ad2c238c201c4253736>, IEnumerable, IEnumerator {

protected override RC_35113aa55a750ad2c238c201c4253736 GetElementDefaultValue() {
return new RC_35113aa55a750ad2c238c201c4253736();
}

public T[] ToArray<T>(Func<RC_35113aa55a750ad2c238c201c4253736, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_45a2a678e0c897a57aacb30f6fec9213 recordList, Func<RC_35113aa55a750ad2c238c201c4253736, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_45a2a678e0c897a57aacb30f6fec9213(RC_35113aa55a750ad2c238c201c4253736[] array) {
  RL_45a2a678e0c897a57aacb30f6fec9213 result = new RL_45a2a678e0c897a57aacb30f6fec9213();
result.InnerFromArray(array);
    return result;
}

public static RL_45a2a678e0c897a57aacb30f6fec9213 ToList<T>(T[] array, Func <T, RC_35113aa55a750ad2c238c201c4253736> converter) {
  RL_45a2a678e0c897a57aacb30f6fec9213 result = new RL_45a2a678e0c897a57aacb30f6fec9213();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_45a2a678e0c897a57aacb30f6fec9213 FromRestList<T>(RestList<T> restList, Func <T, RC_35113aa55a750ad2c238c201c4253736> converter) {
  RL_45a2a678e0c897a57aacb30f6fec9213 result = new RL_45a2a678e0c897a57aacb30f6fec9213();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_45a2a678e0c897a57aacb30f6fec9213() : base() {
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
protected override OSList<RC_35113aa55a750ad2c238c201c4253736> NewList() {
return new RL_45a2a678e0c897a57aacb30f6fec9213();
}


} // RL_45a2a678e0c897a57aacb30f6fec9213
}

