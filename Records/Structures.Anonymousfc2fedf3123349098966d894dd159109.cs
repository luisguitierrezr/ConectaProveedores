namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (8+0v_DMSCUmJZtiU3RWRCQ)
///  <code>RC_bea8613d22251afcd4cf0079dd87bd03</code> that represent
/// s <code>ConceptManualsAppConceptManualUserAreaRecord</code> <p>Description: </p>
/// </summary>
// Name: ConceptManualsAppConceptManualUserAreaRecord
public partial struct RC_bea8613d22251afcd4cf0079dd87bd03 : ITypedRecord<RC_bea8613d22251afcd4cf0079dd87bd03> {
internal static readonly GlobalObjectKey IdConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZoMLp29mjW9tNbd005+SMA");
internal static readonly GlobalObjectKey IdManuals = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SJWDWrbCYmcJ2tn7F5vHbA");
internal static readonly GlobalObjectKey IdAppConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_Yu2sakGXOYHbaHAIBzZ3Q");
internal static readonly GlobalObjectKey IdManualUserArea = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ura_U486M5TwbyafhyuEyA");

public EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord ssENConcept;

public EN_f9557b941e05ea8155a182da4f23a896EntityRecord ssENManuals;

public EN_01808938be8d2f648d79d661d64023eaEntityRecord ssENAppConcept;

public EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord ssENManualUserArea;


public BitArray OptimizedAttributes;

public RC_bea8613d22251afcd4cf0079dd87bd03() {
OptimizedAttributes = null;
ssENConcept = new EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord();
ssENManuals = new EN_f9557b941e05ea8155a182da4f23a896EntityRecord();
ssENAppConcept = new EN_01808938be8d2f648d79d661d64023eaEntityRecord();
ssENManualUserArea = new EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(4,false);
    all[1] = new BitArray(12,false);
    all[2] = new BitArray(4,false);
    all[3] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENManuals.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENAppConcept.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENManualUserArea.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENConcept.OptimizedAttributes = value[0];
    ssENManuals.OptimizedAttributes = value[1];
    ssENAppConcept.OptimizedAttributes = value[2];
    ssENManualUserArea.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENConcept.OptimizedAttributes;
    all[1] = ssENManuals.OptimizedAttributes;
    all[2] = ssENAppConcept.OptimizedAttributes;
    all[3] = ssENManualUserArea.OptimizedAttributes;
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
ssENManuals.Read( r, ref index);
ssENAppConcept.Read( r, ref index);
ssENManualUserArea.Read( r, ref index);
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
public void ReadIM(RC_bea8613d22251afcd4cf0079dd87bd03 r) {
this = r;
}


public static bool operator == (RC_bea8613d22251afcd4cf0079dd87bd03 a, RC_bea8613d22251afcd4cf0079dd87bd03 b) {
if (a.ssENConcept != b.ssENConcept) return false;
if (a.ssENManuals != b.ssENManuals) return false;
if (a.ssENAppConcept != b.ssENAppConcept) return false;
if (a.ssENManualUserArea != b.ssENManualUserArea) return false;
return true;
}

public static bool operator != (RC_bea8613d22251afcd4cf0079dd87bd03 a, RC_bea8613d22251afcd4cf0079dd87bd03 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bea8613d22251afcd4cf0079dd87bd03)) return false;
return (this == (RC_bea8613d22251afcd4cf0079dd87bd03)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENConcept.GetHashCode()
 ^ ssENManuals.GetHashCode()
 ^ ssENAppConcept.GetHashCode()
 ^ ssENManualUserArea.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENConcept.RecursiveReset();
ssENManuals.RecursiveReset();
ssENAppConcept.RecursiveReset();
ssENManualUserArea.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENConcept.InternalRecursiveSave();
ssENManuals.InternalRecursiveSave();
ssENAppConcept.InternalRecursiveSave();
ssENManualUserArea.InternalRecursiveSave();
}


public RC_bea8613d22251afcd4cf0079dd87bd03 Duplicate() {
RC_bea8613d22251afcd4cf0079dd87bd03 t;
t.ssENConcept = (EN_7945e4f5c4cce3a5c682ab4d047fa5f5EntityRecord)this.ssENConcept.Duplicate();
t.ssENManuals = (EN_f9557b941e05ea8155a182da4f23a896EntityRecord)this.ssENManuals.Duplicate();
t.ssENAppConcept = (EN_01808938be8d2f648d79d661d64023eaEntityRecord)this.ssENAppConcept.Duplicate();
t.ssENManualUserArea = (EN_c1c1bc1bc0422e0e8c8d738a051958c0EntityRecord)this.ssENManualUserArea.Duplicate();
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
} else if (head == "manuals") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Manuals")) variable.Value = ssENManuals; else variable.Optimized = true;
variable.SetFieldName("manuals");
} else if (head == "appconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AppConcept")) variable.Value = ssENAppConcept; else variable.Optimized = true;
variable.SetFieldName("appconcept");
} else if (head == "manualuserarea") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ManualUserArea")) variable.Value = ssENManualUserArea; else variable.Optimized = true;
variable.SetFieldName("manualuserarea");
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
if (key == IdConcept) {
return ssENConcept;
}
if (key == IdManuals) {
return ssENManuals;
}
if (key == IdAppConcept) {
return ssENAppConcept;
}
if (key == IdManualUserArea) {
return ssENManualUserArea;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdConcept.Key.AsGuid) {
return ssENConcept;
}
if (attributeKey == IdManuals.Key.AsGuid) {
return ssENManuals;
}
if (attributeKey == IdAppConcept.Key.AsGuid) {
return ssENAppConcept;
}
if (attributeKey == IdManualUserArea.Key.AsGuid) {
return ssENManualUserArea;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENConcept.FillFromOther((IRecord) other.AttributeGet(IdConcept));
ssENManuals.FillFromOther((IRecord) other.AttributeGet(IdManuals));
ssENAppConcept.FillFromOther((IRecord) other.AttributeGet(IdAppConcept));
ssENManualUserArea.FillFromOther((IRecord) other.AttributeGet(IdManualUserArea));
}
} // RC_bea8613d22251afcd4cf0079dd87bd03
/// <summary>
/// RecordList type <code>ConceptManualsAppConceptManualUserAreaRecordList</code> that represents a
///  record list of <code>Concept, Manuals, AppConcept, ManualUserArea</code>
/// </summary>
public partial class RL_3492ef2eba0fe7bdeb0e5335c2e29132 : GenericRecordList<RC_bea8613d22251afcd4cf0079dd87bd03>, IEnumerable, IEnumerator {

protected override RC_bea8613d22251afcd4cf0079dd87bd03 GetElementDefaultValue() {
return new RC_bea8613d22251afcd4cf0079dd87bd03();
}

public T[] ToArray<T>(Func<RC_bea8613d22251afcd4cf0079dd87bd03, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3492ef2eba0fe7bdeb0e5335c2e29132 recordList, Func<RC_bea8613d22251afcd4cf0079dd87bd03, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3492ef2eba0fe7bdeb0e5335c2e29132(RC_bea8613d22251afcd4cf0079dd87bd03[] array) {
  RL_3492ef2eba0fe7bdeb0e5335c2e29132 result = new RL_3492ef2eba0fe7bdeb0e5335c2e29132();
result.InnerFromArray(array);
    return result;
}

public static RL_3492ef2eba0fe7bdeb0e5335c2e29132 ToList<T>(T[] array, Func <T, RC_bea8613d22251afcd4cf0079dd87bd03> converter) {
  RL_3492ef2eba0fe7bdeb0e5335c2e29132 result = new RL_3492ef2eba0fe7bdeb0e5335c2e29132();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3492ef2eba0fe7bdeb0e5335c2e29132 FromRestList<T>(RestList<T> restList, Func <T, RC_bea8613d22251afcd4cf0079dd87bd03> converter) {
  RL_3492ef2eba0fe7bdeb0e5335c2e29132 result = new RL_3492ef2eba0fe7bdeb0e5335c2e29132();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3492ef2eba0fe7bdeb0e5335c2e29132() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(4,false);
def[1] = new BitArray(12,false);
def[2] = new BitArray(4,false);
def[3] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bea8613d22251afcd4cf0079dd87bd03> NewList() {
return new RL_3492ef2eba0fe7bdeb0e5335c2e29132();
}


} // RL_3492ef2eba0fe7bdeb0e5335c2e29132
}

