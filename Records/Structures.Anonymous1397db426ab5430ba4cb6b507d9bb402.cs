namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (QtuXE7VqC0Oky2tQfZu0Ag)
///  <code>RC_29a9641599166c3e50d86e7edc6e64aa</code> that represent
/// s <code>ApplicantTelcelDirectionApplicantRecord</code> <p>Description: </p>
/// </summary>
// Name: ApplicantTelcelDirectionApplicantRecord
public partial struct RC_29a9641599166c3e50d86e7edc6e64aa : ITypedRecord<RC_29a9641599166c3e50d86e7edc6e64aa> {
internal static readonly GlobalObjectKey IdApplicantTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*j9a9Z3tNR+W5o8b8thttxg");
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1NjUn6ehPto37pfIFjlG5g");

public EN_b4df52993ebe05898d08c65589336b17EntityRecord ssENApplicantTelcelDirection;

public EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord ssENApplicant;


public BitArray OptimizedAttributes;

public RC_29a9641599166c3e50d86e7edc6e64aa() {
OptimizedAttributes = null;
ssENApplicantTelcelDirection = new EN_b4df52993ebe05898d08c65589336b17EntityRecord();
ssENApplicant = new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApplicantTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENApplicant.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENApplicantTelcelDirection.OptimizedAttributes = value[0];
    ssENApplicant.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENApplicantTelcelDirection.OptimizedAttributes;
    all[1] = ssENApplicant.OptimizedAttributes;
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
ssENApplicant.Read( r, ref index);
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
public void ReadIM(RC_29a9641599166c3e50d86e7edc6e64aa r) {
this = r;
}


public static bool operator == (RC_29a9641599166c3e50d86e7edc6e64aa a, RC_29a9641599166c3e50d86e7edc6e64aa b) {
if (a.ssENApplicantTelcelDirection != b.ssENApplicantTelcelDirection) return false;
if (a.ssENApplicant != b.ssENApplicant) return false;
return true;
}

public static bool operator != (RC_29a9641599166c3e50d86e7edc6e64aa a, RC_29a9641599166c3e50d86e7edc6e64aa b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_29a9641599166c3e50d86e7edc6e64aa)) return false;
return (this == (RC_29a9641599166c3e50d86e7edc6e64aa)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApplicantTelcelDirection.GetHashCode()
 ^ ssENApplicant.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApplicantTelcelDirection.RecursiveReset();
ssENApplicant.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApplicantTelcelDirection.InternalRecursiveSave();
ssENApplicant.InternalRecursiveSave();
}


public RC_29a9641599166c3e50d86e7edc6e64aa Duplicate() {
RC_29a9641599166c3e50d86e7edc6e64aa t;
t.ssENApplicantTelcelDirection = (EN_b4df52993ebe05898d08c65589336b17EntityRecord)this.ssENApplicantTelcelDirection.Duplicate();
t.ssENApplicant = (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord)this.ssENApplicant.Duplicate();
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
} else if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssENApplicant; else variable.Optimized = true;
variable.SetFieldName("applicant");
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
if (key == IdApplicantTelcelDirection) {
return ssENApplicantTelcelDirection;
}
if (key == IdApplicant) {
return ssENApplicant;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApplicantTelcelDirection.Key.AsGuid) {
return ssENApplicantTelcelDirection;
}
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssENApplicant;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApplicantTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdApplicantTelcelDirection));
ssENApplicant.FillFromOther((IRecord) other.AttributeGet(IdApplicant));
}
} // RC_29a9641599166c3e50d86e7edc6e64aa
/// <summary>
/// RecordList type <code>ApplicantTelcelDirectionApplicantRecordList</code> that represents a record
///  list of <code>ApplicantTelcelDirection, Applicant</code>
/// </summary>
public partial class RL_b56721e24b85ff178b55a9b290c3bf31 : GenericRecordList<RC_29a9641599166c3e50d86e7edc6e64aa>, IEnumerable, IEnumerator {

protected override RC_29a9641599166c3e50d86e7edc6e64aa GetElementDefaultValue() {
return new RC_29a9641599166c3e50d86e7edc6e64aa();
}

public T[] ToArray<T>(Func<RC_29a9641599166c3e50d86e7edc6e64aa, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b56721e24b85ff178b55a9b290c3bf31 recordList, Func<RC_29a9641599166c3e50d86e7edc6e64aa, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b56721e24b85ff178b55a9b290c3bf31(RC_29a9641599166c3e50d86e7edc6e64aa[] array) {
  RL_b56721e24b85ff178b55a9b290c3bf31 result = new RL_b56721e24b85ff178b55a9b290c3bf31();
result.InnerFromArray(array);
    return result;
}

public static RL_b56721e24b85ff178b55a9b290c3bf31 ToList<T>(T[] array, Func <T, RC_29a9641599166c3e50d86e7edc6e64aa> converter) {
  RL_b56721e24b85ff178b55a9b290c3bf31 result = new RL_b56721e24b85ff178b55a9b290c3bf31();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b56721e24b85ff178b55a9b290c3bf31 FromRestList<T>(RestList<T> restList, Func <T, RC_29a9641599166c3e50d86e7edc6e64aa> converter) {
  RL_b56721e24b85ff178b55a9b290c3bf31 result = new RL_b56721e24b85ff178b55a9b290c3bf31();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b56721e24b85ff178b55a9b290c3bf31() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(7,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_29a9641599166c3e50d86e7edc6e64aa> NewList() {
return new RL_b56721e24b85ff178b55a9b290c3bf31();
}


} // RL_b56721e24b85ff178b55a9b290c3bf31
}

