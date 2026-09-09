namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (8i84uXVS4EyYmNe+WGCNsw)
///  <code>RC_5e1572d574f8fe1e39bbadd50daaa59c</code> that represent
/// s <code>DescriptionShortDescriptionTitleIsVideoStarIdRecord</code> <p>Description: </p>
/// </summary>
// Name: DescriptionShortDescriptionTitleIsVideoStarIdRecord
public partial struct RC_5e1572d574f8fe1e39bbadd50daaa59c : ITypedRecord<RC_5e1572d574f8fe1e39bbadd50daaa59c> {
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LjJZK8tMkdS7XE_ByZkY+g");
internal static readonly GlobalObjectKey IdShortDescription = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yqCt9YnQEa29b8B3Dh6Neg");
internal static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rmZ9mIpL6x3iA76B1FUGOw");
internal static readonly GlobalObjectKey IdIsVideo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*arVvuwm9GHVQ9WmHpv07XQ");
internal static readonly GlobalObjectKey IdStar = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zPFVQvWmjSGL02rCBr_Jrg");
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qlpy4BQjfmcH+Uf3jKO29g");

public string ssDescription;

public string ssShortDescription;

public string ssTitle;

public bool ssIsVideo;

public bool ssStar;

public long ssId;


public BitArray OptimizedAttributes;

public RC_5e1572d574f8fe1e39bbadd50daaa59c() {
OptimizedAttributes = null;
ssDescription = "";
ssShortDescription = "";
ssTitle = "";
ssIsVideo = false;
ssStar = false;
ssId = 0L;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssDescription = r.ReadText(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.Description", "");
ssShortDescription = r.ReadText(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.ShortDescription", "");
ssTitle = r.ReadText(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.Title", "");
ssIsVideo = r.ReadBoolean(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.IsVideo", false);
ssStar = r.ReadBoolean(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.Star", false);
ssId = r.ReadEntityReferenceLongInteger(index++, "DescriptionShortDescriptionTitleIsVideoStarIdRecord.Id", 0L);
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
public void ReadIM(RC_5e1572d574f8fe1e39bbadd50daaa59c r) {
this = r;
}


public static bool operator == (RC_5e1572d574f8fe1e39bbadd50daaa59c a, RC_5e1572d574f8fe1e39bbadd50daaa59c b) {
if (a.ssDescription != b.ssDescription) return false;
if (a.ssShortDescription != b.ssShortDescription) return false;
if (a.ssTitle != b.ssTitle) return false;
if (a.ssIsVideo != b.ssIsVideo) return false;
if (a.ssStar != b.ssStar) return false;
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (RC_5e1572d574f8fe1e39bbadd50daaa59c a, RC_5e1572d574f8fe1e39bbadd50daaa59c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5e1572d574f8fe1e39bbadd50daaa59c)) return false;
return (this == (RC_5e1572d574f8fe1e39bbadd50daaa59c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssShortDescription.GetHashCode()
 ^ ssTitle.GetHashCode()
 ^ ssIsVideo.GetHashCode()
 ^ ssStar.GetHashCode()
 ^ ssId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_5e1572d574f8fe1e39bbadd50daaa59c Duplicate() {
RC_5e1572d574f8fe1e39bbadd50daaa59c t;
t.ssDescription = this.ssDescription;
t.ssShortDescription = this.ssShortDescription;
t.ssTitle = this.ssTitle;
t.ssIsVideo = this.ssIsVideo;
t.ssStar = this.ssStar;
t.ssId = this.ssId;
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
if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "shortdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShortDescription")) variable.Value = ssShortDescription; else variable.Optimized = true;
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Title")) variable.Value = ssTitle; else variable.Optimized = true;
} else if (head == "isvideo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsVideo")) variable.Value = ssIsVideo; else variable.Optimized = true;
} else if (head == "star") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Star")) variable.Value = ssStar; else variable.Optimized = true;
} else if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
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
if (key == IdDescription) {
return ssDescription;
}
if (key == IdShortDescription) {
return ssShortDescription;
}
if (key == IdTitle) {
return ssTitle;
}
if (key == IdIsVideo) {
return ssIsVideo;
}
if (key == IdStar) {
return ssStar;
}
if (key == IdId) {
return ssId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdShortDescription.Key.AsGuid) {
return ssShortDescription;
}
if (attributeKey == IdTitle.Key.AsGuid) {
return ssTitle;
}
if (attributeKey == IdIsVideo.Key.AsGuid) {
return ssIsVideo;
}
if (attributeKey == IdStar.Key.AsGuid) {
return ssStar;
}
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDescription = (string) other.AttributeGet(IdDescription);
ssShortDescription = (string) other.AttributeGet(IdShortDescription);
ssTitle = (string) other.AttributeGet(IdTitle);
ssIsVideo = (bool) other.AttributeGet(IdIsVideo);
ssStar = (bool) other.AttributeGet(IdStar);
ssId = (long) other.AttributeGet(IdId);
}
} // RC_5e1572d574f8fe1e39bbadd50daaa59c
/// <summary>
/// RecordList type <code>DescriptionShortDescriptionTitleIsVideoStarIdRecordList</code> that
///  represents a record list of <code>Text, Text, Text, Boolean, Boolean, ManualsIdentifier</code>
/// </summary>
public partial class RL_c03a84418d2a4ae38f50fab5e2cc796f : GenericRecordList<RC_5e1572d574f8fe1e39bbadd50daaa59c>, IEnumerable, IEnumerator {

protected override RC_5e1572d574f8fe1e39bbadd50daaa59c GetElementDefaultValue() {
return new RC_5e1572d574f8fe1e39bbadd50daaa59c();
}

public T[] ToArray<T>(Func<RC_5e1572d574f8fe1e39bbadd50daaa59c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c03a84418d2a4ae38f50fab5e2cc796f recordList, Func<RC_5e1572d574f8fe1e39bbadd50daaa59c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c03a84418d2a4ae38f50fab5e2cc796f(RC_5e1572d574f8fe1e39bbadd50daaa59c[] array) {
  RL_c03a84418d2a4ae38f50fab5e2cc796f result = new RL_c03a84418d2a4ae38f50fab5e2cc796f();
result.InnerFromArray(array);
    return result;
}

public static RL_c03a84418d2a4ae38f50fab5e2cc796f ToList<T>(T[] array, Func <T, RC_5e1572d574f8fe1e39bbadd50daaa59c> converter) {
  RL_c03a84418d2a4ae38f50fab5e2cc796f result = new RL_c03a84418d2a4ae38f50fab5e2cc796f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c03a84418d2a4ae38f50fab5e2cc796f FromRestList<T>(RestList<T> restList, Func <T, RC_5e1572d574f8fe1e39bbadd50daaa59c> converter) {
  RL_c03a84418d2a4ae38f50fab5e2cc796f result = new RL_c03a84418d2a4ae38f50fab5e2cc796f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c03a84418d2a4ae38f50fab5e2cc796f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5e1572d574f8fe1e39bbadd50daaa59c> NewList() {
return new RL_c03a84418d2a4ae38f50fab5e2cc796f();
}


} // RL_c03a84418d2a4ae38f50fab5e2cc796f
}

