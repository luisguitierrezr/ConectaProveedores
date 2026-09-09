namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GNmyDOXGPEuJfQQboNlbNQ)
///  <code>RC_924fb1c0e7e255405c78f78b86a50c36</code> that represent
/// s <code>OrderRequestFileOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileOrderMainRecord
public partial struct RC_924fb1c0e7e255405c78f78b86a50c36 : ITypedRecord<RC_924fb1c0e7e255405c78f78b86a50c36> {
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bBLYcy5yTSvWYtqyvxpy0Q");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_924fb1c0e7e255405c78f78b86a50c36() {
OptimizedAttributes = null;
ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(17,false);
    all[1] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderRequestFile.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderRequestFile.OptimizedAttributes;
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
ssENOrderRequestFile.Read( r, ref index);
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
public void ReadIM(RC_924fb1c0e7e255405c78f78b86a50c36 r) {
this = r;
}


public static bool operator == (RC_924fb1c0e7e255405c78f78b86a50c36 a, RC_924fb1c0e7e255405c78f78b86a50c36 b) {
if (a.ssENOrderRequestFile != b.ssENOrderRequestFile) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_924fb1c0e7e255405c78f78b86a50c36 a, RC_924fb1c0e7e255405c78f78b86a50c36 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_924fb1c0e7e255405c78f78b86a50c36)) return false;
return (this == (RC_924fb1c0e7e255405c78f78b86a50c36)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderRequestFile.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderRequestFile.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderRequestFile.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_924fb1c0e7e255405c78f78b86a50c36 Duplicate() {
RC_924fb1c0e7e255405c78f78b86a50c36 t;
t.ssENOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssENOrderRequestFile.Duplicate();
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
if (head == "orderrequestfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFile")) variable.Value = ssENOrderRequestFile; else variable.Optimized = true;
variable.SetFieldName("orderrequestfile");
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
if (key == IdOrderRequestFile) {
return ssENOrderRequestFile;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFile.Key.AsGuid) {
return ssENOrderRequestFile;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_924fb1c0e7e255405c78f78b86a50c36
/// <summary>
/// RecordList type <code>OrderRequestFileOrderMainRecordList</code> that represents a record list of
///  <code>OrderRequestFile, OrderMain</code>
/// </summary>
public partial class RL_c628da75cf1ff630b097c83103a52e40 : GenericRecordList<RC_924fb1c0e7e255405c78f78b86a50c36>, IEnumerable, IEnumerator {

protected override RC_924fb1c0e7e255405c78f78b86a50c36 GetElementDefaultValue() {
return new RC_924fb1c0e7e255405c78f78b86a50c36();
}

public T[] ToArray<T>(Func<RC_924fb1c0e7e255405c78f78b86a50c36, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c628da75cf1ff630b097c83103a52e40 recordList, Func<RC_924fb1c0e7e255405c78f78b86a50c36, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c628da75cf1ff630b097c83103a52e40(RC_924fb1c0e7e255405c78f78b86a50c36[] array) {
  RL_c628da75cf1ff630b097c83103a52e40 result = new RL_c628da75cf1ff630b097c83103a52e40();
result.InnerFromArray(array);
    return result;
}

public static RL_c628da75cf1ff630b097c83103a52e40 ToList<T>(T[] array, Func <T, RC_924fb1c0e7e255405c78f78b86a50c36> converter) {
  RL_c628da75cf1ff630b097c83103a52e40 result = new RL_c628da75cf1ff630b097c83103a52e40();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c628da75cf1ff630b097c83103a52e40 FromRestList<T>(RestList<T> restList, Func <T, RC_924fb1c0e7e255405c78f78b86a50c36> converter) {
  RL_c628da75cf1ff630b097c83103a52e40 result = new RL_c628da75cf1ff630b097c83103a52e40();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c628da75cf1ff630b097c83103a52e40() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(17,false);
def[1] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_924fb1c0e7e255405c78f78b86a50c36> NewList() {
return new RL_c628da75cf1ff630b097c83103a52e40();
}


} // RL_c628da75cf1ff630b097c83103a52e40
}

