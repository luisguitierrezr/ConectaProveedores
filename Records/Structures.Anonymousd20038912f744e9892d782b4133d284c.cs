namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (kTgA0nQvmE6S14K0Ez0oTA)
///  <code>RC_67bdd68f4d7be547b9a3c6fcb61b6dc6</code> that represent
/// s <code>ApplicantTelcelDirectionRecord</code> <p>Description: </p>
/// </summary>
// Name: ApplicantTelcelDirectionRecord
public partial struct RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 : ITypedRecord<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6> {
internal static readonly GlobalObjectKey IdApplicantTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*j9a9Z3tNR+W5o8b8thttxg");

public EN_b4df52993ebe05898d08c65589336b17EntityRecord ssENApplicantTelcelDirection;


public static implicit operator EN_b4df52993ebe05898d08c65589336b17EntityRecord( RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 r) {
return r.ssENApplicantTelcelDirection;
}

public static implicit operator RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 (EN_b4df52993ebe05898d08c65589336b17EntityRecord r) {
RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 res = new RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 ();
res.ssENApplicantTelcelDirection = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENApplicantTelcelDirection.ChangedAttributes = value;
}
get {
    return ssENApplicantTelcelDirection.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_67bdd68f4d7be547b9a3c6fcb61b6dc6() {
OptimizedAttributes = null;
ssENApplicantTelcelDirection = new EN_b4df52993ebe05898d08c65589336b17EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApplicantTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENApplicantTelcelDirection.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENApplicantTelcelDirection.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApplicantTelcelDirection.Read( r, ref index);
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
public void ReadIM(RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 r) {
this = r;
}


public static bool operator == (RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 a, RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 b) {
if (a.ssENApplicantTelcelDirection != b.ssENApplicantTelcelDirection) return false;
return true;
}

public static bool operator != (RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 a, RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_67bdd68f4d7be547b9a3c6fcb61b6dc6)) return false;
return (this == (RC_67bdd68f4d7be547b9a3c6fcb61b6dc6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApplicantTelcelDirection.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApplicantTelcelDirection.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApplicantTelcelDirection.InternalRecursiveSave();
}


public RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 Duplicate() {
RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 t;
t.ssENApplicantTelcelDirection = (EN_b4df52993ebe05898d08c65589336b17EntityRecord)this.ssENApplicantTelcelDirection.Duplicate();
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
if (head == "applicanttelceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicantTelcelDirection")) variable.Value = ssENApplicantTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("applicanttelceldirection");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENApplicantTelcelDirection.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENApplicantTelcelDirection.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdApplicantTelcelDirection) {
return ssENApplicantTelcelDirection;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApplicantTelcelDirection.Key.AsGuid) {
return ssENApplicantTelcelDirection;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApplicantTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdApplicantTelcelDirection));
}
} // RC_67bdd68f4d7be547b9a3c6fcb61b6dc6
/// <summary>
/// RecordList type <code>ApplicantTelcelDirectionRecordList</code> that represents a record list of
///  <code>ApplicantTelcelDirection</code>
/// </summary>
public partial class RL_7aabe763bc18b8101a88b3aef8498ef5 : GenericRecordList<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6>, IEnumerable, IEnumerator {

protected override RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 GetElementDefaultValue() {
return new RC_67bdd68f4d7be547b9a3c6fcb61b6dc6();
}

public T[] ToArray<T>(Func<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7aabe763bc18b8101a88b3aef8498ef5 recordList, Func<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7aabe763bc18b8101a88b3aef8498ef5(RC_67bdd68f4d7be547b9a3c6fcb61b6dc6[] array) {
  RL_7aabe763bc18b8101a88b3aef8498ef5 result = new RL_7aabe763bc18b8101a88b3aef8498ef5();
result.InnerFromArray(array);
    return result;
}

public static RL_7aabe763bc18b8101a88b3aef8498ef5 ToList<T>(T[] array, Func <T, RC_67bdd68f4d7be547b9a3c6fcb61b6dc6> converter) {
  RL_7aabe763bc18b8101a88b3aef8498ef5 result = new RL_7aabe763bc18b8101a88b3aef8498ef5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7aabe763bc18b8101a88b3aef8498ef5 FromRestList<T>(RestList<T> restList, Func <T, RC_67bdd68f4d7be547b9a3c6fcb61b6dc6> converter) {
  RL_7aabe763bc18b8101a88b3aef8498ef5 result = new RL_7aabe763bc18b8101a88b3aef8498ef5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7aabe763bc18b8101a88b3aef8498ef5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6> NewList() {
return new RL_7aabe763bc18b8101a88b3aef8498ef5();
}


} // RL_7aabe763bc18b8101a88b3aef8498ef5
}

