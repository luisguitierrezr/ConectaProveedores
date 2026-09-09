namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (QTNHdo0dokWaBgy16scq+Q)
///  <code>RC_b1b68bfd06a9e65c076da1c0201cd9dd</code> that represents <code>AppConceptRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AppConceptRecord
public partial struct RC_b1b68bfd06a9e65c076da1c0201cd9dd : ITypedRecord<RC_b1b68bfd06a9e65c076da1c0201cd9dd> {
internal static readonly GlobalObjectKey IdAppConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_Yu2sakGXOYHbaHAIBzZ3Q");

public EN_01808938be8d2f648d79d661d64023eaEntityRecord ssENAppConcept;


public static implicit operator EN_01808938be8d2f648d79d661d64023eaEntityRecord( RC_b1b68bfd06a9e65c076da1c0201cd9dd r) {
return r.ssENAppConcept;
}

public static implicit operator RC_b1b68bfd06a9e65c076da1c0201cd9dd (EN_01808938be8d2f648d79d661d64023eaEntityRecord r) {
RC_b1b68bfd06a9e65c076da1c0201cd9dd res = new RC_b1b68bfd06a9e65c076da1c0201cd9dd ();
res.ssENAppConcept = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAppConcept.ChangedAttributes = value;
}
get {
    return ssENAppConcept.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b1b68bfd06a9e65c076da1c0201cd9dd() {
OptimizedAttributes = null;
ssENAppConcept = new EN_01808938be8d2f648d79d661d64023eaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAppConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAppConcept.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAppConcept.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAppConcept.Read( r, ref index);
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
public void ReadIM(RC_b1b68bfd06a9e65c076da1c0201cd9dd r) {
this = r;
}


public static bool operator == (RC_b1b68bfd06a9e65c076da1c0201cd9dd a, RC_b1b68bfd06a9e65c076da1c0201cd9dd b) {
if (a.ssENAppConcept != b.ssENAppConcept) return false;
return true;
}

public static bool operator != (RC_b1b68bfd06a9e65c076da1c0201cd9dd a, RC_b1b68bfd06a9e65c076da1c0201cd9dd b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b1b68bfd06a9e65c076da1c0201cd9dd)) return false;
return (this == (RC_b1b68bfd06a9e65c076da1c0201cd9dd)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAppConcept.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAppConcept.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAppConcept.InternalRecursiveSave();
}


public RC_b1b68bfd06a9e65c076da1c0201cd9dd Duplicate() {
RC_b1b68bfd06a9e65c076da1c0201cd9dd t;
t.ssENAppConcept = (EN_01808938be8d2f648d79d661d64023eaEntityRecord)this.ssENAppConcept.Duplicate();
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
if (head == "appconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AppConcept")) variable.Value = ssENAppConcept; else variable.Optimized = true;
variable.SetFieldName("appconcept");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAppConcept.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAppConcept.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAppConcept) {
return ssENAppConcept;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAppConcept.Key.AsGuid) {
return ssENAppConcept;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAppConcept.FillFromOther((IRecord) other.AttributeGet(IdAppConcept));
}
} // RC_b1b68bfd06a9e65c076da1c0201cd9dd
/// <summary>
/// RecordList type <code>AppConceptRecordList</code> that represents a record list of
///  <code>AppConcept</code>
/// </summary>
public partial class RL_c05bd86479c228d179fb255ebfce07bc : GenericRecordList<RC_b1b68bfd06a9e65c076da1c0201cd9dd>, IEnumerable, IEnumerator {

protected override RC_b1b68bfd06a9e65c076da1c0201cd9dd GetElementDefaultValue() {
return new RC_b1b68bfd06a9e65c076da1c0201cd9dd();
}

public T[] ToArray<T>(Func<RC_b1b68bfd06a9e65c076da1c0201cd9dd, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c05bd86479c228d179fb255ebfce07bc recordList, Func<RC_b1b68bfd06a9e65c076da1c0201cd9dd, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c05bd86479c228d179fb255ebfce07bc(RC_b1b68bfd06a9e65c076da1c0201cd9dd[] array) {
  RL_c05bd86479c228d179fb255ebfce07bc result = new RL_c05bd86479c228d179fb255ebfce07bc();
result.InnerFromArray(array);
    return result;
}

public static RL_c05bd86479c228d179fb255ebfce07bc ToList<T>(T[] array, Func <T, RC_b1b68bfd06a9e65c076da1c0201cd9dd> converter) {
  RL_c05bd86479c228d179fb255ebfce07bc result = new RL_c05bd86479c228d179fb255ebfce07bc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c05bd86479c228d179fb255ebfce07bc FromRestList<T>(RestList<T> restList, Func <T, RC_b1b68bfd06a9e65c076da1c0201cd9dd> converter) {
  RL_c05bd86479c228d179fb255ebfce07bc result = new RL_c05bd86479c228d179fb255ebfce07bc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c05bd86479c228d179fb255ebfce07bc() : base() {
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
protected override OSList<RC_b1b68bfd06a9e65c076da1c0201cd9dd> NewList() {
return new RL_c05bd86479c228d179fb255ebfce07bc();
}


} // RL_c05bd86479c228d179fb255ebfce07bc
}

