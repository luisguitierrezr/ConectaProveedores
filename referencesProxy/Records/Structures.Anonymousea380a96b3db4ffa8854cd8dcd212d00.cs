namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (lgo46tuz+k+IVM2NzSEtAA)
///  <code>RC_a70b8366666f6f8d6d35b774d39f9230</code> that represents <code>ConceptRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ConceptRecord
public partial struct RC_a70b8366666f6f8d6d35b774d39f9230 : ITypedRecord<RC_a70b8366666f6f8d6d35b774d39f9230> {
internal static readonly GlobalObjectKey IdConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZoMLp29mjW9tNbd005+SMA");

public EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord ssENConcept;


public static implicit operator EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord( RC_a70b8366666f6f8d6d35b774d39f9230 r) {
return r.ssENConcept;
}

public static implicit operator RC_a70b8366666f6f8d6d35b774d39f9230 (EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord r) {
RC_a70b8366666f6f8d6d35b774d39f9230 res = new RC_a70b8366666f6f8d6d35b774d39f9230 ();
res.ssENConcept = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENConcept.ChangedAttributes = value;
}
get {
    return ssENConcept.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a70b8366666f6f8d6d35b774d39f9230() {
OptimizedAttributes = null;
ssENConcept = new EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENConcept.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENConcept.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENConcept.Read( r, ref index);
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
public void ReadIM(RC_a70b8366666f6f8d6d35b774d39f9230 r) {
this = r;
}


public static bool operator == (RC_a70b8366666f6f8d6d35b774d39f9230 a, RC_a70b8366666f6f8d6d35b774d39f9230 b) {
if (a.ssENConcept != b.ssENConcept) return false;
return true;
}

public static bool operator != (RC_a70b8366666f6f8d6d35b774d39f9230 a, RC_a70b8366666f6f8d6d35b774d39f9230 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a70b8366666f6f8d6d35b774d39f9230)) return false;
return (this == (RC_a70b8366666f6f8d6d35b774d39f9230)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENConcept.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENConcept.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENConcept.InternalRecursiveSave();
}


public RC_a70b8366666f6f8d6d35b774d39f9230 Duplicate() {
RC_a70b8366666f6f8d6d35b774d39f9230 t;
t.ssENConcept = (EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord)this.ssENConcept.Duplicate();
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
if (head == "concept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Concept")) variable.Value = ssENConcept; else variable.Optimized = true;
variable.SetFieldName("concept");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENConcept.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENConcept.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdConcept) {
return ssENConcept;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdConcept.Key.AsGuid) {
return ssENConcept;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENConcept.FillFromOther((IRecord) other.AttributeGet(IdConcept));
}
} // RC_a70b8366666f6f8d6d35b774d39f9230
/// <summary>
/// RecordList type <code>ConceptRecordList</code> that represents a record list of
///  <code>Concept</code>
/// </summary>
public partial class RL_87574534255a485c2abd5b115b6235e7 : GenericRecordList<RC_a70b8366666f6f8d6d35b774d39f9230>, IEnumerable, IEnumerator {

protected override RC_a70b8366666f6f8d6d35b774d39f9230 GetElementDefaultValue() {
return new RC_a70b8366666f6f8d6d35b774d39f9230();
}

public T[] ToArray<T>(Func<RC_a70b8366666f6f8d6d35b774d39f9230, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_87574534255a485c2abd5b115b6235e7 recordList, Func<RC_a70b8366666f6f8d6d35b774d39f9230, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_87574534255a485c2abd5b115b6235e7(RC_a70b8366666f6f8d6d35b774d39f9230[] array) {
  RL_87574534255a485c2abd5b115b6235e7 result = new RL_87574534255a485c2abd5b115b6235e7();
result.InnerFromArray(array);
    return result;
}

public static RL_87574534255a485c2abd5b115b6235e7 ToList<T>(T[] array, Func <T, RC_a70b8366666f6f8d6d35b774d39f9230> converter) {
  RL_87574534255a485c2abd5b115b6235e7 result = new RL_87574534255a485c2abd5b115b6235e7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_87574534255a485c2abd5b115b6235e7 FromRestList<T>(RestList<T> restList, Func <T, RC_a70b8366666f6f8d6d35b774d39f9230> converter) {
  RL_87574534255a485c2abd5b115b6235e7 result = new RL_87574534255a485c2abd5b115b6235e7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_87574534255a485c2abd5b115b6235e7() : base() {
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
protected override OSList<RC_a70b8366666f6f8d6d35b774d39f9230> NewList() {
return new RL_87574534255a485c2abd5b115b6235e7();
}


} // RL_87574534255a485c2abd5b115b6235e7
}

