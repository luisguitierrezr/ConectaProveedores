namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (yRerhSy8V0WDrM359FW59g)
///  <code>RC_158d774b1951665b144a20e40b8bb511</code> that represent
/// s <code>OrderApprovalOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderApprovalOrderMainRecord
public partial struct RC_158d774b1951665b144a20e40b8bb511 : ITypedRecord<RC_158d774b1951665b144a20e40b8bb511> {
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_158d774b1951665b144a20e40b8bb511() {
OptimizedAttributes = null;
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderApproval.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderApproval.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderApproval.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_158d774b1951665b144a20e40b8bb511 r) {
this = r;
}


public static bool operator == (RC_158d774b1951665b144a20e40b8bb511 a, RC_158d774b1951665b144a20e40b8bb511 b) {
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_158d774b1951665b144a20e40b8bb511 a, RC_158d774b1951665b144a20e40b8bb511 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_158d774b1951665b144a20e40b8bb511)) return false;
return (this == (RC_158d774b1951665b144a20e40b8bb511)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderApproval.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderApproval.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_158d774b1951665b144a20e40b8bb511 Duplicate() {
RC_158d774b1951665b144a20e40b8bb511 t;
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_158d774b1951665b144a20e40b8bb511
/// <summary>
/// RecordList type <code>OrderApprovalOrderMainRecordList</code> that represents a record list of
///  <code>OrderApproval, OrderMain</code>
/// </summary>
public partial class RL_4ff1b710be996e0ae107a46588f5914b : GenericRecordList<RC_158d774b1951665b144a20e40b8bb511>, IEnumerable, IEnumerator {

protected override RC_158d774b1951665b144a20e40b8bb511 GetElementDefaultValue() {
return new RC_158d774b1951665b144a20e40b8bb511();
}

public T[] ToArray<T>(Func<RC_158d774b1951665b144a20e40b8bb511, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4ff1b710be996e0ae107a46588f5914b recordList, Func<RC_158d774b1951665b144a20e40b8bb511, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4ff1b710be996e0ae107a46588f5914b(RC_158d774b1951665b144a20e40b8bb511[] array) {
  RL_4ff1b710be996e0ae107a46588f5914b result = new RL_4ff1b710be996e0ae107a46588f5914b();
result.InnerFromArray(array);
    return result;
}

public static RL_4ff1b710be996e0ae107a46588f5914b ToList<T>(T[] array, Func <T, RC_158d774b1951665b144a20e40b8bb511> converter) {
  RL_4ff1b710be996e0ae107a46588f5914b result = new RL_4ff1b710be996e0ae107a46588f5914b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4ff1b710be996e0ae107a46588f5914b FromRestList<T>(RestList<T> restList, Func <T, RC_158d774b1951665b144a20e40b8bb511> converter) {
  RL_4ff1b710be996e0ae107a46588f5914b result = new RL_4ff1b710be996e0ae107a46588f5914b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4ff1b710be996e0ae107a46588f5914b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_158d774b1951665b144a20e40b8bb511> NewList() {
return new RL_4ff1b710be996e0ae107a46588f5914b();
}


} // RL_4ff1b710be996e0ae107a46588f5914b
}

