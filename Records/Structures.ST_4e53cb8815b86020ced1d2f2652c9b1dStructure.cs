namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] DropdownOptionalConfigs (5o8nVPnFFEeyTXBja1332g)
///  <code>ST_4e53cb8815b86020ced1d2f2652c9b1dStructure</code> that represent
/// s <code>DropdownOptionalConfigs</code> <p>Description: DropdownSearch optional configurations</p>
/// </summary>
// Name: DropdownOptionalConfigs
public partial struct ST_4e53cb8815b86020ced1d2f2652c9b1dStructure : ITypedRecord<ST_4e53cb8815b86020ced1d2f2652c9b1dStructure> {
internal static readonly GlobalObjectKey IdAllowMultipleSelection = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*HaR1JtDFpkyXBXRTi1LSqg");
internal static readonly GlobalObjectKey IdIsDisabled = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*DAMRG_g9Xk29q5JUfhr3iA");
internal static readonly GlobalObjectKey IdNoResultsText = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*+ep+qZnSwUWOxx87IyK5gQ");
internal static readonly GlobalObjectKey IdSearchPrompt = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*N7hx41SRn0C0el2IDGSKvA");
internal static readonly GlobalObjectKey IdNoOptionsText = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*oEhUN9ALDEykrPqOoono8g");
internal static readonly GlobalObjectKey IdSanitizeDropdownValues = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*3t_Ka5MC70S4BNPQDgxIvg");

public bool ssAllowMultipleSelection;

public bool ssIsDisabled;

public string ssNoResultsText;

public string ssSearchPrompt;

public string ssNoOptionsText;

public bool ssSanitizeDropdownValues;


public BitArray OptimizedAttributes;

public ST_4e53cb8815b86020ced1d2f2652c9b1dStructure() {
OptimizedAttributes = null;
ssAllowMultipleSelection = false;
ssIsDisabled = false;
ssNoResultsText = RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DropdownOptionalConfigs_ReferenceStructureAttribute_NoResultsText;
ssSearchPrompt = RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DropdownOptionalConfigs_ReferenceStructureAttribute_SearchPrompt;
ssNoOptionsText = RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DropdownOptionalConfigs_ReferenceStructureAttribute_NoOptionsText;
ssSanitizeDropdownValues = false;
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
ssAllowMultipleSelection = r.ReadBoolean(index++, "DropdownOptionalConfigs.AllowMultipleSelection", false);
ssIsDisabled = r.ReadBoolean(index++, "DropdownOptionalConfigs.IsDisabled", false);
ssNoResultsText = r.ReadText(index++, "DropdownOptionalConfigs.NoResultsText", "");
ssSearchPrompt = r.ReadText(index++, "DropdownOptionalConfigs.SearchPrompt", "");
ssNoOptionsText = r.ReadText(index++, "DropdownOptionalConfigs.NoOptionsText", "");
ssSanitizeDropdownValues = r.ReadBoolean(index++, "DropdownOptionalConfigs.SanitizeDropdownValues", false);
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
public void ReadIM(ST_4e53cb8815b86020ced1d2f2652c9b1dStructure r) {
this = r;
}


public static bool operator == (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure a, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure b) {
if (a.ssAllowMultipleSelection != b.ssAllowMultipleSelection) return false;
if (a.ssIsDisabled != b.ssIsDisabled) return false;
if (a.ssNoResultsText != b.ssNoResultsText) return false;
if (a.ssSearchPrompt != b.ssSearchPrompt) return false;
if (a.ssNoOptionsText != b.ssNoOptionsText) return false;
if (a.ssSanitizeDropdownValues != b.ssSanitizeDropdownValues) return false;
return true;
}

public static bool operator != (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure a, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure)) return false;
return (this == (ST_4e53cb8815b86020ced1d2f2652c9b1dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAllowMultipleSelection.GetHashCode()
 ^ ssIsDisabled.GetHashCode()
 ^ ssNoResultsText.GetHashCode()
 ^ ssSearchPrompt.GetHashCode()
 ^ ssNoOptionsText.GetHashCode()
 ^ ssSanitizeDropdownValues.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_4e53cb8815b86020ced1d2f2652c9b1dStructure Duplicate() {
ST_4e53cb8815b86020ced1d2f2652c9b1dStructure t;
t.ssAllowMultipleSelection = this.ssAllowMultipleSelection;
t.ssIsDisabled = this.ssIsDisabled;
t.ssNoResultsText = this.ssNoResultsText;
t.ssSearchPrompt = this.ssSearchPrompt;
t.ssNoOptionsText = this.ssNoOptionsText;
t.ssSanitizeDropdownValues = this.ssSanitizeDropdownValues;
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
if (head == "allowmultipleselection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllowMultipleSelection")) variable.Value = ssAllowMultipleSelection; else variable.Optimized = true;
} else if (head == "isdisabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDisabled")) variable.Value = ssIsDisabled; else variable.Optimized = true;
} else if (head == "noresultstext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NoResultsText")) variable.Value = ssNoResultsText; else variable.Optimized = true;
} else if (head == "searchprompt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SearchPrompt")) variable.Value = ssSearchPrompt; else variable.Optimized = true;
} else if (head == "nooptionstext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NoOptionsText")) variable.Value = ssNoOptionsText; else variable.Optimized = true;
} else if (head == "sanitizedropdownvalues") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SanitizeDropdownValues")) variable.Value = ssSanitizeDropdownValues; else variable.Optimized = true;
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
if (key == IdAllowMultipleSelection) {
return ssAllowMultipleSelection;
}
if (key == IdIsDisabled) {
return ssIsDisabled;
}
if (key == IdNoResultsText) {
return ssNoResultsText;
}
if (key == IdSearchPrompt) {
return ssSearchPrompt;
}
if (key == IdNoOptionsText) {
return ssNoOptionsText;
}
if (key == IdSanitizeDropdownValues) {
return ssSanitizeDropdownValues;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAllowMultipleSelection.Key.AsGuid) {
return ssAllowMultipleSelection;
}
if (attributeKey == IdIsDisabled.Key.AsGuid) {
return ssIsDisabled;
}
if (attributeKey == IdNoResultsText.Key.AsGuid) {
return ssNoResultsText;
}
if (attributeKey == IdSearchPrompt.Key.AsGuid) {
return ssSearchPrompt;
}
if (attributeKey == IdNoOptionsText.Key.AsGuid) {
return ssNoOptionsText;
}
if (attributeKey == IdSanitizeDropdownValues.Key.AsGuid) {
return ssSanitizeDropdownValues;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAllowMultipleSelection = (bool) other.AttributeGet(IdAllowMultipleSelection);
ssIsDisabled = (bool) other.AttributeGet(IdIsDisabled);
ssNoResultsText = (string) other.AttributeGet(IdNoResultsText);
ssSearchPrompt = (string) other.AttributeGet(IdSearchPrompt);
ssNoOptionsText = (string) other.AttributeGet(IdNoOptionsText);
ssSanitizeDropdownValues = (bool) other.AttributeGet(IdSanitizeDropdownValues);
}
} // ST_4e53cb8815b86020ced1d2f2652c9b1dStructure
/// <summary>
/// RecordList type <code>DropdownOptionalConfigsList</code> that represents a record list of
///  <code>DropdownOptionalConfigs</code>
/// </summary>
public partial class RL_fea339219699b0d78ea5a0c4450d0c70 : GenericRecordList<ST_4e53cb8815b86020ced1d2f2652c9b1dStructure>, IEnumerable, IEnumerator {

protected override ST_4e53cb8815b86020ced1d2f2652c9b1dStructure GetElementDefaultValue() {
return new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
}

public T[] ToArray<T>(Func<ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fea339219699b0d78ea5a0c4450d0c70 recordList, Func<ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fea339219699b0d78ea5a0c4450d0c70(ST_4e53cb8815b86020ced1d2f2652c9b1dStructure[] array) {
  RL_fea339219699b0d78ea5a0c4450d0c70 result = new RL_fea339219699b0d78ea5a0c4450d0c70();
result.InnerFromArray(array);
    return result;
}

public static RL_fea339219699b0d78ea5a0c4450d0c70 ToList<T>(T[] array, Func <T, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure> converter) {
  RL_fea339219699b0d78ea5a0c4450d0c70 result = new RL_fea339219699b0d78ea5a0c4450d0c70();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fea339219699b0d78ea5a0c4450d0c70 FromRestList<T>(RestList<T> restList, Func <T, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure> converter) {
  RL_fea339219699b0d78ea5a0c4450d0c70 result = new RL_fea339219699b0d78ea5a0c4450d0c70();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fea339219699b0d78ea5a0c4450d0c70() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_4e53cb8815b86020ced1d2f2652c9b1dStructure> NewList() {
return new RL_fea339219699b0d78ea5a0c4450d0c70();
}


} // RL_fea339219699b0d78ea5a0c4450d0c70
}

