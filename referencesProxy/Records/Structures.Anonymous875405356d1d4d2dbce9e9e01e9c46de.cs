namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (NQVUhx1tLU286engHpxG3g)
///  <code>RC_ba5df53107d79696b2775256d21bdd62</code> that represent
/// s <code>AdvancePaymentTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: AdvancePaymentTypeRecord
public partial struct RC_ba5df53107d79696b2775256d21bdd62 : ITypedRecord<RC_ba5df53107d79696b2775256d21bdd62> {
internal static readonly GlobalObjectKey IdAdvancePaymentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MfVdutcHlpayd1JW0hvdYg");

public EN_485b44f219737098b3b1029e90069935EntityRecord ssENAdvancePaymentType;


public static implicit operator EN_485b44f219737098b3b1029e90069935EntityRecord( RC_ba5df53107d79696b2775256d21bdd62 r) {
return r.ssENAdvancePaymentType;
}

public static implicit operator RC_ba5df53107d79696b2775256d21bdd62 (EN_485b44f219737098b3b1029e90069935EntityRecord r) {
RC_ba5df53107d79696b2775256d21bdd62 res = new RC_ba5df53107d79696b2775256d21bdd62 ();
res.ssENAdvancePaymentType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAdvancePaymentType.ChangedAttributes = value;
}
get {
    return ssENAdvancePaymentType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ba5df53107d79696b2775256d21bdd62() {
OptimizedAttributes = null;
ssENAdvancePaymentType = new EN_485b44f219737098b3b1029e90069935EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAdvancePaymentType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAdvancePaymentType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAdvancePaymentType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAdvancePaymentType.Read( r, ref index);
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
public void ReadIM(RC_ba5df53107d79696b2775256d21bdd62 r) {
this = r;
}


public static bool operator == (RC_ba5df53107d79696b2775256d21bdd62 a, RC_ba5df53107d79696b2775256d21bdd62 b) {
if (a.ssENAdvancePaymentType != b.ssENAdvancePaymentType) return false;
return true;
}

public static bool operator != (RC_ba5df53107d79696b2775256d21bdd62 a, RC_ba5df53107d79696b2775256d21bdd62 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ba5df53107d79696b2775256d21bdd62)) return false;
return (this == (RC_ba5df53107d79696b2775256d21bdd62)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAdvancePaymentType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAdvancePaymentType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAdvancePaymentType.InternalRecursiveSave();
}


public RC_ba5df53107d79696b2775256d21bdd62 Duplicate() {
RC_ba5df53107d79696b2775256d21bdd62 t;
t.ssENAdvancePaymentType = (EN_485b44f219737098b3b1029e90069935EntityRecord)this.ssENAdvancePaymentType.Duplicate();
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
if (head == "advancepaymenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvancePaymentType")) variable.Value = ssENAdvancePaymentType; else variable.Optimized = true;
variable.SetFieldName("advancepaymenttype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAdvancePaymentType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAdvancePaymentType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAdvancePaymentType) {
return ssENAdvancePaymentType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAdvancePaymentType.Key.AsGuid) {
return ssENAdvancePaymentType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAdvancePaymentType.FillFromOther((IRecord) other.AttributeGet(IdAdvancePaymentType));
}
} // RC_ba5df53107d79696b2775256d21bdd62
/// <summary>
/// RecordList type <code>AdvancePaymentTypeRecordList</code> that represents a record list of
///  <code>AdvancePaymentType</code>
/// </summary>
public partial class RL_0d443dd02abe633532f6b939b4573e00 : GenericRecordList<RC_ba5df53107d79696b2775256d21bdd62>, IEnumerable, IEnumerator {

protected override RC_ba5df53107d79696b2775256d21bdd62 GetElementDefaultValue() {
return new RC_ba5df53107d79696b2775256d21bdd62();
}

public T[] ToArray<T>(Func<RC_ba5df53107d79696b2775256d21bdd62, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0d443dd02abe633532f6b939b4573e00 recordList, Func<RC_ba5df53107d79696b2775256d21bdd62, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0d443dd02abe633532f6b939b4573e00(RC_ba5df53107d79696b2775256d21bdd62[] array) {
  RL_0d443dd02abe633532f6b939b4573e00 result = new RL_0d443dd02abe633532f6b939b4573e00();
result.InnerFromArray(array);
    return result;
}

public static RL_0d443dd02abe633532f6b939b4573e00 ToList<T>(T[] array, Func <T, RC_ba5df53107d79696b2775256d21bdd62> converter) {
  RL_0d443dd02abe633532f6b939b4573e00 result = new RL_0d443dd02abe633532f6b939b4573e00();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0d443dd02abe633532f6b939b4573e00 FromRestList<T>(RestList<T> restList, Func <T, RC_ba5df53107d79696b2775256d21bdd62> converter) {
  RL_0d443dd02abe633532f6b939b4573e00 result = new RL_0d443dd02abe633532f6b939b4573e00();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0d443dd02abe633532f6b939b4573e00() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ba5df53107d79696b2775256d21bdd62> NewList() {
return new RL_0d443dd02abe633532f6b939b4573e00();
}


} // RL_0d443dd02abe633532f6b939b4573e00
}

