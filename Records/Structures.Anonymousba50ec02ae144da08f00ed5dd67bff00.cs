namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (AuxQuhSuoE2PAO1d1nv_AA)
///  <code>RC_73fae6920f82113320dccc89ef073c01</code> that represent
/// s <code>AccordionIconTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: AccordionIconTypeRecord
public partial struct RC_73fae6920f82113320dccc89ef073c01 : ITypedRecord<RC_73fae6920f82113320dccc89ef073c01> {
internal static readonly GlobalObjectKey IdAccordionIconType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kub6c4IPMxEg3MyJ7wc8AQ");

public EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord ssENAccordionIconType;


public static implicit operator EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord( RC_73fae6920f82113320dccc89ef073c01 r) {
return r.ssENAccordionIconType;
}

public static implicit operator RC_73fae6920f82113320dccc89ef073c01 (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord r) {
RC_73fae6920f82113320dccc89ef073c01 res = new RC_73fae6920f82113320dccc89ef073c01 ();
res.ssENAccordionIconType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAccordionIconType.ChangedAttributes = value;
}
get {
    return ssENAccordionIconType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_73fae6920f82113320dccc89ef073c01() {
OptimizedAttributes = null;
ssENAccordionIconType = new EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAccordionIconType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAccordionIconType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAccordionIconType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAccordionIconType.Read( r, ref index);
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
public void ReadIM(RC_73fae6920f82113320dccc89ef073c01 r) {
this = r;
}


public static bool operator == (RC_73fae6920f82113320dccc89ef073c01 a, RC_73fae6920f82113320dccc89ef073c01 b) {
if (a.ssENAccordionIconType != b.ssENAccordionIconType) return false;
return true;
}

public static bool operator != (RC_73fae6920f82113320dccc89ef073c01 a, RC_73fae6920f82113320dccc89ef073c01 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_73fae6920f82113320dccc89ef073c01)) return false;
return (this == (RC_73fae6920f82113320dccc89ef073c01)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAccordionIconType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAccordionIconType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAccordionIconType.InternalRecursiveSave();
}


public RC_73fae6920f82113320dccc89ef073c01 Duplicate() {
RC_73fae6920f82113320dccc89ef073c01 t;
t.ssENAccordionIconType = (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord)this.ssENAccordionIconType.Duplicate();
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
if (head == "accordionicontype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccordionIconType")) variable.Value = ssENAccordionIconType; else variable.Optimized = true;
variable.SetFieldName("accordionicontype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAccordionIconType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAccordionIconType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAccordionIconType) {
return ssENAccordionIconType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccordionIconType.Key.AsGuid) {
return ssENAccordionIconType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAccordionIconType.FillFromOther((IRecord) other.AttributeGet(IdAccordionIconType));
}
} // RC_73fae6920f82113320dccc89ef073c01
/// <summary>
/// RecordList type <code>AccordionIconTypeRecordList</code> that represents a record list of
///  <code>AccordionIconType</code>
/// </summary>
public partial class RL_452bae0381b3504e486b471d2123e658 : GenericRecordList<RC_73fae6920f82113320dccc89ef073c01>, IEnumerable, IEnumerator {

protected override RC_73fae6920f82113320dccc89ef073c01 GetElementDefaultValue() {
return new RC_73fae6920f82113320dccc89ef073c01();
}

public T[] ToArray<T>(Func<RC_73fae6920f82113320dccc89ef073c01, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_452bae0381b3504e486b471d2123e658 recordList, Func<RC_73fae6920f82113320dccc89ef073c01, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_452bae0381b3504e486b471d2123e658(RC_73fae6920f82113320dccc89ef073c01[] array) {
  RL_452bae0381b3504e486b471d2123e658 result = new RL_452bae0381b3504e486b471d2123e658();
result.InnerFromArray(array);
    return result;
}

public static RL_452bae0381b3504e486b471d2123e658 ToList<T>(T[] array, Func <T, RC_73fae6920f82113320dccc89ef073c01> converter) {
  RL_452bae0381b3504e486b471d2123e658 result = new RL_452bae0381b3504e486b471d2123e658();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_452bae0381b3504e486b471d2123e658 FromRestList<T>(RestList<T> restList, Func <T, RC_73fae6920f82113320dccc89ef073c01> converter) {
  RL_452bae0381b3504e486b471d2123e658 result = new RL_452bae0381b3504e486b471d2123e658();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_452bae0381b3504e486b471d2123e658() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_73fae6920f82113320dccc89ef073c01> NewList() {
return new RL_452bae0381b3504e486b471d2123e658();
}


} // RL_452bae0381b3504e486b471d2123e658
}

