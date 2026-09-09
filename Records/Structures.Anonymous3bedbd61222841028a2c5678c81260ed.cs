namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Yb3tOygiAkGKLFZ4yBJg7Q)
///  <code>RC_cf58ea0f756ca06745169deb0b41c0eb</code> that represent
/// s <code>OrderItemEntriesOrderMainItemRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderItemEntriesOrderMainItemRecord
public partial struct RC_cf58ea0f756ca06745169deb0b41c0eb : ITypedRecord<RC_cf58ea0f756ca06745169deb0b41c0eb> {
internal static readonly GlobalObjectKey IdOrderItemEntries = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wtz5J4HeLU0E1NGPW4xCSw");
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");

public EN_0eb2cf39b93366f50855e537f6b98500EntityRecord ssENOrderItemEntries;

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;


public BitArray OptimizedAttributes;

public RC_cf58ea0f756ca06745169deb0b41c0eb() {
OptimizedAttributes = null;
ssENOrderItemEntries = new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord();
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(51,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderItemEntries.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderItemEntries.OptimizedAttributes = value[0];
    ssENOrderMainItem.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderItemEntries.OptimizedAttributes;
    all[1] = ssENOrderMainItem.OptimizedAttributes;
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
public void ReadIM(RC_cf58ea0f756ca06745169deb0b41c0eb r) {
this = r;
}


public static bool operator == (RC_cf58ea0f756ca06745169deb0b41c0eb a, RC_cf58ea0f756ca06745169deb0b41c0eb b) {
if (a.ssENOrderItemEntries != b.ssENOrderItemEntries) return false;
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
return true;
}

public static bool operator != (RC_cf58ea0f756ca06745169deb0b41c0eb a, RC_cf58ea0f756ca06745169deb0b41c0eb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cf58ea0f756ca06745169deb0b41c0eb)) return false;
return (this == (RC_cf58ea0f756ca06745169deb0b41c0eb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderItemEntries.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderItemEntries.RecursiveReset();
ssENOrderMainItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderItemEntries.InternalRecursiveSave();
ssENOrderMainItem.InternalRecursiveSave();
}


public RC_cf58ea0f756ca06745169deb0b41c0eb Duplicate() {
RC_cf58ea0f756ca06745169deb0b41c0eb t;
t.ssENOrderItemEntries = (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord)this.ssENOrderItemEntries.Duplicate();
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderItemEntries.Key.AsGuid) {
return ssENOrderItemEntries;
}
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderItemEntries.FillFromOther((IRecord) other.AttributeGet(IdOrderItemEntries));
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
}
} // RC_cf58ea0f756ca06745169deb0b41c0eb
/// <summary>
/// RecordList type <code>OrderItemEntriesOrderMainItemRecordList</code> that represents a record list
///  of <code>OrderItemEntries, OrderMainItem</code>
/// </summary>
public partial class RL_3dd9bb7875fde1313207084bc3e4eb42 : GenericRecordList<RC_cf58ea0f756ca06745169deb0b41c0eb>, IEnumerable, IEnumerator {

protected override RC_cf58ea0f756ca06745169deb0b41c0eb GetElementDefaultValue() {
return new RC_cf58ea0f756ca06745169deb0b41c0eb();
}

public T[] ToArray<T>(Func<RC_cf58ea0f756ca06745169deb0b41c0eb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3dd9bb7875fde1313207084bc3e4eb42 recordList, Func<RC_cf58ea0f756ca06745169deb0b41c0eb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3dd9bb7875fde1313207084bc3e4eb42(RC_cf58ea0f756ca06745169deb0b41c0eb[] array) {
  RL_3dd9bb7875fde1313207084bc3e4eb42 result = new RL_3dd9bb7875fde1313207084bc3e4eb42();
result.InnerFromArray(array);
    return result;
}

public static RL_3dd9bb7875fde1313207084bc3e4eb42 ToList<T>(T[] array, Func <T, RC_cf58ea0f756ca06745169deb0b41c0eb> converter) {
  RL_3dd9bb7875fde1313207084bc3e4eb42 result = new RL_3dd9bb7875fde1313207084bc3e4eb42();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3dd9bb7875fde1313207084bc3e4eb42 FromRestList<T>(RestList<T> restList, Func <T, RC_cf58ea0f756ca06745169deb0b41c0eb> converter) {
  RL_3dd9bb7875fde1313207084bc3e4eb42 result = new RL_3dd9bb7875fde1313207084bc3e4eb42();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3dd9bb7875fde1313207084bc3e4eb42() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(51,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cf58ea0f756ca06745169deb0b41c0eb> NewList() {
return new RL_3dd9bb7875fde1313207084bc3e4eb42();
}


} // RL_3dd9bb7875fde1313207084bc3e4eb42
}

