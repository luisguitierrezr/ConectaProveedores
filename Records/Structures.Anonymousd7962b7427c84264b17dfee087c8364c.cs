namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (dCuW18gnZEKxff7gh8g2TA)
///  <code>RC_fab74841dcf4769bb7fe99529b7664cf</code> that represent
/// s <code>OrderItemEntriesOrderMainItemOrderMainLineSumRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderItemEntriesOrderMainItemOrderMainLineSumRecord
public partial struct RC_fab74841dcf4769bb7fe99529b7664cf : ITypedRecord<RC_fab74841dcf4769bb7fe99529b7664cf> {
internal static readonly GlobalObjectKey IdOrderItemEntries = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wtz5J4HeLU0E1NGPW4xCSw");
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdLineSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HnCLJDFHFREr+2I9qBjRVA");

public EN_0eb2cf39b93366f50855e537f6b98500EntityRecord ssENOrderItemEntries;

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public decimal ssLineSum;


public BitArray OptimizedAttributes;

public RC_fab74841dcf4769bb7fe99529b7664cf() {
OptimizedAttributes = null;
ssENOrderItemEntries = new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord();
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssLineSum = 0.0M;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(51,false);
    all[2] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderItemEntries.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderItemEntries.OptimizedAttributes = value[0];
    ssENOrderMainItem.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderItemEntries.OptimizedAttributes;
    all[1] = ssENOrderMainItem.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderItemEntries.Read( r, ref index);
ssENOrderMainItem.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssLineSum = r.ReadDecimal(index++, "OrderItemEntriesOrderMainItemOrderMainLineSumRecord.LineSum", 0.0M);
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
public void ReadIM(RC_fab74841dcf4769bb7fe99529b7664cf r) {
this = r;
}


public static bool operator == (RC_fab74841dcf4769bb7fe99529b7664cf a, RC_fab74841dcf4769bb7fe99529b7664cf b) {
if (a.ssENOrderItemEntries != b.ssENOrderItemEntries) return false;
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssLineSum != b.ssLineSum) return false;
return true;
}

public static bool operator != (RC_fab74841dcf4769bb7fe99529b7664cf a, RC_fab74841dcf4769bb7fe99529b7664cf b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fab74841dcf4769bb7fe99529b7664cf)) return false;
return (this == (RC_fab74841dcf4769bb7fe99529b7664cf)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderItemEntries.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssLineSum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderItemEntries.RecursiveReset();
ssENOrderMainItem.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderItemEntries.InternalRecursiveSave();
ssENOrderMainItem.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_fab74841dcf4769bb7fe99529b7664cf Duplicate() {
RC_fab74841dcf4769bb7fe99529b7664cf t;
t.ssENOrderItemEntries = (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord)this.ssENOrderItemEntries.Duplicate();
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssLineSum = this.ssLineSum;
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
if (head == "orderitementries") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderItemEntries")) variable.Value = ssENOrderItemEntries; else variable.Optimized = true;
variable.SetFieldName("orderitementries");
} else if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "linesum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LineSum")) variable.Value = ssLineSum; else variable.Optimized = true;
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
if (key == IdOrderItemEntries) {
return ssENOrderItemEntries;
}
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdLineSum) {
return ssLineSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderItemEntries.Key.AsGuid) {
return ssENOrderItemEntries;
}
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdLineSum.Key.AsGuid) {
return ssLineSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderItemEntries.FillFromOther((IRecord) other.AttributeGet(IdOrderItemEntries));
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssLineSum = (decimal) other.AttributeGet(IdLineSum);
}
} // RC_fab74841dcf4769bb7fe99529b7664cf
/// <summary>
/// RecordList type <code>OrderItemEntriesOrderMainItemOrderMainLineSumRecordList</code> that
///  represents a record list of <code>OrderItemEntries, OrderMainItem, OrderMain, Decimal</code>
/// </summary>
public partial class RL_a19a7c29ddd1ff67f1606bfe5bd968f7 : GenericRecordList<RC_fab74841dcf4769bb7fe99529b7664cf>, IEnumerable, IEnumerator {

protected override RC_fab74841dcf4769bb7fe99529b7664cf GetElementDefaultValue() {
return new RC_fab74841dcf4769bb7fe99529b7664cf();
}

public T[] ToArray<T>(Func<RC_fab74841dcf4769bb7fe99529b7664cf, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a19a7c29ddd1ff67f1606bfe5bd968f7 recordList, Func<RC_fab74841dcf4769bb7fe99529b7664cf, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a19a7c29ddd1ff67f1606bfe5bd968f7(RC_fab74841dcf4769bb7fe99529b7664cf[] array) {
  RL_a19a7c29ddd1ff67f1606bfe5bd968f7 result = new RL_a19a7c29ddd1ff67f1606bfe5bd968f7();
result.InnerFromArray(array);
    return result;
}

public static RL_a19a7c29ddd1ff67f1606bfe5bd968f7 ToList<T>(T[] array, Func <T, RC_fab74841dcf4769bb7fe99529b7664cf> converter) {
  RL_a19a7c29ddd1ff67f1606bfe5bd968f7 result = new RL_a19a7c29ddd1ff67f1606bfe5bd968f7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a19a7c29ddd1ff67f1606bfe5bd968f7 FromRestList<T>(RestList<T> restList, Func <T, RC_fab74841dcf4769bb7fe99529b7664cf> converter) {
  RL_a19a7c29ddd1ff67f1606bfe5bd968f7 result = new RL_a19a7c29ddd1ff67f1606bfe5bd968f7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a19a7c29ddd1ff67f1606bfe5bd968f7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(8,false);
def[1] = new BitArray(51,false);
def[2] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_fab74841dcf4769bb7fe99529b7664cf> NewList() {
return new RL_a19a7c29ddd1ff67f1606bfe5bd968f7();
}


} // RL_a19a7c29ddd1ff67f1606bfe5bd968f7
}

