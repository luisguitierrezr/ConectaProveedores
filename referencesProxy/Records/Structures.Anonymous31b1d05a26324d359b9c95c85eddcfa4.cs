namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (WtCxMTImNU2bnJXIXt3PpA)
///  <code>RC_fe70e85a2080a52611f1c24f3043653c</code> that represents <code>InternalConceptRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InternalConceptRecord
public partial struct RC_fe70e85a2080a52611f1c24f3043653c : ITypedRecord<RC_fe70e85a2080a52611f1c24f3043653c> {
internal static readonly GlobalObjectKey IdInternalConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Wuhw_oAgJqUR8cJPMENlPA");

public EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord ssENInternalConcept;


public static implicit operator EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord( RC_fe70e85a2080a52611f1c24f3043653c r) {
return r.ssENInternalConcept;
}

public static implicit operator RC_fe70e85a2080a52611f1c24f3043653c (EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord r) {
RC_fe70e85a2080a52611f1c24f3043653c res = new RC_fe70e85a2080a52611f1c24f3043653c ();
res.ssENInternalConcept = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInternalConcept.ChangedAttributes = value;
}
get {
    return ssENInternalConcept.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_fe70e85a2080a52611f1c24f3043653c() {
OptimizedAttributes = null;
ssENInternalConcept = new EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInternalConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInternalConcept.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInternalConcept.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInternalConcept.Read( r, ref index);
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
public void ReadIM(RC_fe70e85a2080a52611f1c24f3043653c r) {
this = r;
}


public static bool operator == (RC_fe70e85a2080a52611f1c24f3043653c a, RC_fe70e85a2080a52611f1c24f3043653c b) {
if (a.ssENInternalConcept != b.ssENInternalConcept) return false;
return true;
}

public static bool operator != (RC_fe70e85a2080a52611f1c24f3043653c a, RC_fe70e85a2080a52611f1c24f3043653c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fe70e85a2080a52611f1c24f3043653c)) return false;
return (this == (RC_fe70e85a2080a52611f1c24f3043653c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInternalConcept.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInternalConcept.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInternalConcept.InternalRecursiveSave();
}


public RC_fe70e85a2080a52611f1c24f3043653c Duplicate() {
RC_fe70e85a2080a52611f1c24f3043653c t;
t.ssENInternalConcept = (EN_fe6b6b86d321d6ba4bf3e1bb030636f3EntityRecord)this.ssENInternalConcept.Duplicate();
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
if (head == "internalconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InternalConcept")) variable.Value = ssENInternalConcept; else variable.Optimized = true;
variable.SetFieldName("internalconcept");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInternalConcept.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInternalConcept.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInternalConcept) {
return ssENInternalConcept;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInternalConcept.Key.AsGuid) {
return ssENInternalConcept;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInternalConcept.FillFromOther((IRecord) other.AttributeGet(IdInternalConcept));
}
} // RC_fe70e85a2080a52611f1c24f3043653c
/// <summary>
/// RecordList type <code>InternalConceptRecordList</code> that represents a record list of
///  <code>InternalConcept</code>
/// </summary>
public partial class RL_bb2aa13935e96221dbf27ffee6cd2e8a : GenericRecordList<RC_fe70e85a2080a52611f1c24f3043653c>, IEnumerable, IEnumerator {

protected override RC_fe70e85a2080a52611f1c24f3043653c GetElementDefaultValue() {
return new RC_fe70e85a2080a52611f1c24f3043653c();
}

public T[] ToArray<T>(Func<RC_fe70e85a2080a52611f1c24f3043653c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bb2aa13935e96221dbf27ffee6cd2e8a recordList, Func<RC_fe70e85a2080a52611f1c24f3043653c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bb2aa13935e96221dbf27ffee6cd2e8a(RC_fe70e85a2080a52611f1c24f3043653c[] array) {
  RL_bb2aa13935e96221dbf27ffee6cd2e8a result = new RL_bb2aa13935e96221dbf27ffee6cd2e8a();
result.InnerFromArray(array);
    return result;
}

public static RL_bb2aa13935e96221dbf27ffee6cd2e8a ToList<T>(T[] array, Func <T, RC_fe70e85a2080a52611f1c24f3043653c> converter) {
  RL_bb2aa13935e96221dbf27ffee6cd2e8a result = new RL_bb2aa13935e96221dbf27ffee6cd2e8a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bb2aa13935e96221dbf27ffee6cd2e8a FromRestList<T>(RestList<T> restList, Func <T, RC_fe70e85a2080a52611f1c24f3043653c> converter) {
  RL_bb2aa13935e96221dbf27ffee6cd2e8a result = new RL_bb2aa13935e96221dbf27ffee6cd2e8a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bb2aa13935e96221dbf27ffee6cd2e8a() : base() {
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
protected override OSList<RC_fe70e85a2080a52611f1c24f3043653c> NewList() {
return new RL_bb2aa13935e96221dbf27ffee6cd2e8a();
}


} // RL_bb2aa13935e96221dbf27ffee6cd2e8a
}

