namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (sybXa9S4ykmJxTc2_MarKQ)
///  <code>RC_5d55fb38ff8b802f4f2bfe6c27a16f41</code> that represent
/// s <code>OrderAccConceptsOrderAccountingRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderAccConceptsOrderAccountingRecord
public partial struct RC_5d55fb38ff8b802f4f2bfe6c27a16f41 : ITypedRecord<RC_5d55fb38ff8b802f4f2bfe6c27a16f41> {
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");
internal static readonly GlobalObjectKey IdOrderAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OM_CLcG8i2ozjcXqmlxkRg");

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;

public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting;


public BitArray OptimizedAttributes;

public RC_5d55fb38ff8b802f4f2bfe6c27a16f41() {
OptimizedAttributes = null;
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssENOrderAccounting = new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderAccConcepts.OptimizedAttributes = value[0];
    ssENOrderAccounting.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderAccConcepts.OptimizedAttributes;
    all[1] = ssENOrderAccounting.OptimizedAttributes;
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
ssENOrderAccounting.Read( r, ref index);
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
public void ReadIM(RC_5d55fb38ff8b802f4f2bfe6c27a16f41 r) {
this = r;
}


public static bool operator == (RC_5d55fb38ff8b802f4f2bfe6c27a16f41 a, RC_5d55fb38ff8b802f4f2bfe6c27a16f41 b) {
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
if (a.ssENOrderAccounting != b.ssENOrderAccounting) return false;
return true;
}

public static bool operator != (RC_5d55fb38ff8b802f4f2bfe6c27a16f41 a, RC_5d55fb38ff8b802f4f2bfe6c27a16f41 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5d55fb38ff8b802f4f2bfe6c27a16f41)) return false;
return (this == (RC_5d55fb38ff8b802f4f2bfe6c27a16f41)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
 ^ ssENOrderAccounting.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderAccConcepts.RecursiveReset();
ssENOrderAccounting.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderAccConcepts.InternalRecursiveSave();
ssENOrderAccounting.InternalRecursiveSave();
}


public RC_5d55fb38ff8b802f4f2bfe6c27a16f41 Duplicate() {
RC_5d55fb38ff8b802f4f2bfe6c27a16f41 t;
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
t.ssENOrderAccounting = (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord)this.ssENOrderAccounting.Duplicate();
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
} else if (head == "orderaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccounting")) variable.Value = ssENOrderAccounting; else variable.Optimized = true;
variable.SetFieldName("orderaccounting");
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
if (key == IdOrderAccConcepts) {
return ssENOrderAccConcepts;
}
if (key == IdOrderAccounting) {
return ssENOrderAccounting;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderAccConcepts.Key.AsGuid) {
return ssENOrderAccConcepts;
}
if (attributeKey == IdOrderAccounting.Key.AsGuid) {
return ssENOrderAccounting;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdOrderAccConcepts));
ssENOrderAccounting.FillFromOther((IRecord) other.AttributeGet(IdOrderAccounting));
}
} // RC_5d55fb38ff8b802f4f2bfe6c27a16f41
/// <summary>
/// RecordList type <code>OrderAccConceptsOrderAccountingRecordList</code> that represents a record
///  list of <code>OrderAccConcepts, OrderAccounting</code>
/// </summary>
public partial class RL_95478e9152f7ff2a4dfc55ed7d144ff5 : GenericRecordList<RC_5d55fb38ff8b802f4f2bfe6c27a16f41>, IEnumerable, IEnumerator {

protected override RC_5d55fb38ff8b802f4f2bfe6c27a16f41 GetElementDefaultValue() {
return new RC_5d55fb38ff8b802f4f2bfe6c27a16f41();
}

public T[] ToArray<T>(Func<RC_5d55fb38ff8b802f4f2bfe6c27a16f41, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_95478e9152f7ff2a4dfc55ed7d144ff5 recordList, Func<RC_5d55fb38ff8b802f4f2bfe6c27a16f41, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_95478e9152f7ff2a4dfc55ed7d144ff5(RC_5d55fb38ff8b802f4f2bfe6c27a16f41[] array) {
  RL_95478e9152f7ff2a4dfc55ed7d144ff5 result = new RL_95478e9152f7ff2a4dfc55ed7d144ff5();
result.InnerFromArray(array);
    return result;
}

public static RL_95478e9152f7ff2a4dfc55ed7d144ff5 ToList<T>(T[] array, Func <T, RC_5d55fb38ff8b802f4f2bfe6c27a16f41> converter) {
  RL_95478e9152f7ff2a4dfc55ed7d144ff5 result = new RL_95478e9152f7ff2a4dfc55ed7d144ff5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_95478e9152f7ff2a4dfc55ed7d144ff5 FromRestList<T>(RestList<T> restList, Func <T, RC_5d55fb38ff8b802f4f2bfe6c27a16f41> converter) {
  RL_95478e9152f7ff2a4dfc55ed7d144ff5 result = new RL_95478e9152f7ff2a4dfc55ed7d144ff5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_95478e9152f7ff2a4dfc55ed7d144ff5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(14,false);
def[1] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5d55fb38ff8b802f4f2bfe6c27a16f41> NewList() {
return new RL_95478e9152f7ff2a4dfc55ed7d144ff5();
}


} // RL_95478e9152f7ff2a4dfc55ed7d144ff5
}

