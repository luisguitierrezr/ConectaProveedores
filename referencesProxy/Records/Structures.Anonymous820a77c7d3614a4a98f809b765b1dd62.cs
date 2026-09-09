namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (x3cKgmHTSkqY+Am3ZbHdYg)
///  <code>RC_46f699009338b3c2298787ee4b6262ec</code> that represent
/// s <code>SpecialWorkflowUploadPuestosRecord</code> <p>Description: </p>
/// </summary>
// Name: SpecialWorkflowUploadPuestosRecord
public partial struct RC_46f699009338b3c2298787ee4b6262ec : ITypedRecord<RC_46f699009338b3c2298787ee4b6262ec> {
internal static readonly GlobalObjectKey IdSpecialWorkflowUploadPuestos = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AJn2RjiTwrMph4fuS2Ji7A");

public EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord ssENSpecialWorkflowUploadPuestos;


public static implicit operator EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord( RC_46f699009338b3c2298787ee4b6262ec r) {
return r.ssENSpecialWorkflowUploadPuestos;
}

public static implicit operator RC_46f699009338b3c2298787ee4b6262ec (EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord r) {
RC_46f699009338b3c2298787ee4b6262ec res = new RC_46f699009338b3c2298787ee4b6262ec ();
res.ssENSpecialWorkflowUploadPuestos = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSpecialWorkflowUploadPuestos.ChangedAttributes = value;
}
get {
    return ssENSpecialWorkflowUploadPuestos.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_46f699009338b3c2298787ee4b6262ec() {
OptimizedAttributes = null;
ssENSpecialWorkflowUploadPuestos = new EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSpecialWorkflowUploadPuestos.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSpecialWorkflowUploadPuestos.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSpecialWorkflowUploadPuestos.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSpecialWorkflowUploadPuestos.Read( r, ref index);
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
public void ReadIM(RC_46f699009338b3c2298787ee4b6262ec r) {
this = r;
}


public static bool operator == (RC_46f699009338b3c2298787ee4b6262ec a, RC_46f699009338b3c2298787ee4b6262ec b) {
if (a.ssENSpecialWorkflowUploadPuestos != b.ssENSpecialWorkflowUploadPuestos) return false;
return true;
}

public static bool operator != (RC_46f699009338b3c2298787ee4b6262ec a, RC_46f699009338b3c2298787ee4b6262ec b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_46f699009338b3c2298787ee4b6262ec)) return false;
return (this == (RC_46f699009338b3c2298787ee4b6262ec)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSpecialWorkflowUploadPuestos.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSpecialWorkflowUploadPuestos.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSpecialWorkflowUploadPuestos.InternalRecursiveSave();
}


public RC_46f699009338b3c2298787ee4b6262ec Duplicate() {
RC_46f699009338b3c2298787ee4b6262ec t;
t.ssENSpecialWorkflowUploadPuestos = (EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord)this.ssENSpecialWorkflowUploadPuestos.Duplicate();
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
if (head == "specialworkflowuploadpuestos") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialWorkflowUploadPuestos")) variable.Value = ssENSpecialWorkflowUploadPuestos; else variable.Optimized = true;
variable.SetFieldName("specialworkflowuploadpuestos");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSpecialWorkflowUploadPuestos.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSpecialWorkflowUploadPuestos.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSpecialWorkflowUploadPuestos) {
return ssENSpecialWorkflowUploadPuestos;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSpecialWorkflowUploadPuestos.Key.AsGuid) {
return ssENSpecialWorkflowUploadPuestos;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSpecialWorkflowUploadPuestos.FillFromOther((IRecord) other.AttributeGet(IdSpecialWorkflowUploadPuestos));
}
} // RC_46f699009338b3c2298787ee4b6262ec
/// <summary>
/// RecordList type <code>SpecialWorkflowUploadPuestosRecordList</code> that represents a record list
///  of <code>SpecialWorkflowUploadPuestos</code>
/// </summary>
public partial class RL_b58bfa2e14419223bdc811bb9a0743c7 : GenericRecordList<RC_46f699009338b3c2298787ee4b6262ec>, IEnumerable, IEnumerator {

protected override RC_46f699009338b3c2298787ee4b6262ec GetElementDefaultValue() {
return new RC_46f699009338b3c2298787ee4b6262ec();
}

public T[] ToArray<T>(Func<RC_46f699009338b3c2298787ee4b6262ec, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b58bfa2e14419223bdc811bb9a0743c7 recordList, Func<RC_46f699009338b3c2298787ee4b6262ec, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b58bfa2e14419223bdc811bb9a0743c7(RC_46f699009338b3c2298787ee4b6262ec[] array) {
  RL_b58bfa2e14419223bdc811bb9a0743c7 result = new RL_b58bfa2e14419223bdc811bb9a0743c7();
result.InnerFromArray(array);
    return result;
}

public static RL_b58bfa2e14419223bdc811bb9a0743c7 ToList<T>(T[] array, Func <T, RC_46f699009338b3c2298787ee4b6262ec> converter) {
  RL_b58bfa2e14419223bdc811bb9a0743c7 result = new RL_b58bfa2e14419223bdc811bb9a0743c7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b58bfa2e14419223bdc811bb9a0743c7 FromRestList<T>(RestList<T> restList, Func <T, RC_46f699009338b3c2298787ee4b6262ec> converter) {
  RL_b58bfa2e14419223bdc811bb9a0743c7 result = new RL_b58bfa2e14419223bdc811bb9a0743c7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b58bfa2e14419223bdc811bb9a0743c7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_46f699009338b3c2298787ee4b6262ec> NewList() {
return new RL_b58bfa2e14419223bdc811bb9a0743c7();
}


} // RL_b58bfa2e14419223bdc811bb9a0743c7
}

